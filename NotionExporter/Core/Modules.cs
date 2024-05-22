using System.Globalization;
using Microsoft.Extensions.Logging;
using NotionExporter.Core.Logging;
using System.Reflection;
using NotionExporter.API;
using NotionExporter.Core.BuiltInModules;
using Math = NotionExporter.Core.BuiltInModules.Math;
using Module = NotionExporter.API.Module;
using SettingsManager = NotionExporter.Core.Settings.SettingsManager;

namespace NotionExporter.Core
{
    internal static class Modules
    {
        private static readonly InstanceInfo InstanceInfo = new();

        public static readonly List<Module> BuiltInModules =
        [
            new Paragraph(),
            new Math()
        ];

        public static readonly List<Module> ModulesList = [];

        public static void LoadModules()
        {
            ModulesList.Clear();

            var logger = Logger.Factory?.CreateLogger("Modules");

            // Load Built in modules
            foreach (var module in BuiltInModules)
            {
                var className = module.GetType().FullName;
                using (logger?.BeginScope(new Dictionary<string, object>
                       {
                           ["ModulePath"] = className!,
                           ["Built-In"] = true
                       }))
                {
                    logger?.LogInformation("Loading built-in module");

                    try
                    {
                        LoadModule(logger, module, className!);
                    }
                    catch (Exception ex)
                    {
                        logger?.LogError(ex, "Failed to load built-in module");
                    }
                }
            }

            var path = Path.Combine(Environment.CurrentDirectory, "modules");
            var files = Directory.GetFiles(path, "*.dll");
            foreach (var file in files)
            {
                using (logger?.BeginScope(new Dictionary<string, object>
                       {
                           ["ModulePath"] = file,
                           ["Built-In"] = false
                       }))
                {
                    logger?.LogInformation("Loading module");

                    try
                    {
                        var dll = Assembly.Load(File.ReadAllBytes(file));

                        var typeFound = false;
                        foreach (var type in dll.GetExportedTypes())
                        {
                            if (!type.IsSubclassOf(typeof(Module))) continue;

                            logger?.LogInformation($"Found module main class to be {type.Name}");
                            typeFound = true;

                            var module = (Module)Activator.CreateInstance(type)!;
                            var className = module.GetType().FullName!;
                            module.FullPath = file;

                            LoadModule(logger, module, className);
                            break;
                        }

                        if (!typeFound)
                        {
                            logger?.LogError(
                                "Module does not have a main class that extends NotionExporter.API.Module");
                        }
                    }
                    catch (Exception ex)
                    {
                        logger?.LogError(ex, "Failed to load module");
                    }
                }
            }
        }

        private static bool IsModuleDisabled(string className)
        {
            return SettingsManager.Settings.DisabledModules.Contains(className);
        }

        private static void LoadModule(ILogger? logger, Module module, string className)
        {
            module.Disabled = !module.BuiltIn && IsModuleDisabled(className);

            module.InitModule(Logger.Factory?.CreateLogger(className!), InstanceInfo);
            var name = module.GetName();

            if (module.Disabled)
            {
                logger?.LogInformation("Module is disabled");
                ModulesList.Add(module);
                return;
            }

            logger?.LogInformation("Loading settings for module");
            LoadModuleSettings(module, className);

            logger?.LogInformation($"Loaded module {name}");

            ModulesList.Add(module);
        }

        private static void LoadModuleSettings(Module module, string className)
        {
            var deserializeGlobal = module.GetSettingsManager().DeserializeGlobalSettings;
            if (deserializeGlobal != null)
            {
                if (SettingsManager.Settings.ModuleSettings.TryGetValue(className, out var moduleSettings))
                    deserializeGlobal(moduleSettings);
            }

            var deserializeProfile = module.GetSettingsManager().DeserializeProfileSettings;
            if (deserializeProfile != null)
            {
                if (AppContext.CurrentProfile.ModuleSettings.TryGetValue(className,
                        out var moduleSettings))
                    deserializeProfile(moduleSettings);
            }
        }

        public static void DisableModule(Module module)
        {
            if (module.BuiltIn) throw new InvalidOperationException("Attempted to disable built-in module");

            module.Disabled = true;
            if (!SettingsManager.Settings.DisabledModules.Contains(module.GetType().FullName!))
            {
                SettingsManager.Settings.DisabledModules.Add(module.GetType().FullName!);
            }

            SettingsManager.WriteSettings();

            module.OnDisable();
        }

        public static void EnableModule(Module module)
        {
            module.Disabled = false;
            SettingsManager.Settings.DisabledModules.RemoveAll(n => n == module.GetType().FullName!);
            SettingsManager.WriteSettings();

            module.OnEnable();
        }

        public static void AddModule(string filename)
        {
            var logger = Logger.Factory?.CreateLogger("Modules");

            var path = Path.Combine(Environment.CurrentDirectory, "modules");
            var dest = Path.Combine(path, Path.GetFileName(filename));
            File.Copy(filename, dest);

            using (logger?.BeginScope(new Dictionary<string, object>
                   {
                       ["ModulePath"] = dest,
                       ["Built-In"] = false
                   }))
            {
                logger?.LogInformation("Loading module");

                try
                {
                    var dll = Assembly.Load(File.ReadAllBytes(dest));

                    var typeFound = false;
                    foreach (var type in dll.GetExportedTypes())
                    {
                        if (!type.IsSubclassOf(typeof(Module))) continue;

                        logger?.LogInformation($"Found module main class to be {type.Name}");
                        typeFound = true;

                        var module = (Module)Activator.CreateInstance(type)!;
                        var className = module.GetType().FullName!;
                        module.FullPath = dest;

                        LoadModule(logger, module, className);
                        break;
                    }

                    if (!typeFound)
                    {
                        logger?.LogError(
                            "Module does not have a main class that extends NotionExporter.API.Module");
                    }
                }
                catch (Exception ex)
                {
                    logger?.LogError(ex, "Failed to load module");
                }
            }
        }

        public static void RemoveModule(Module module)
        {
            File.Delete(module.FullPath);

            ModulesList.Remove(module);
        }
    }

    internal class InstanceInfo : IInstanceInfo
    {
        public bool IsBuiltInProfile() => AppContext.CurrentProfile.BuiltIn;
        public CultureInfo CurrentLocale() => Languages.Locale;
        public bool IsRightToLeft() => Languages.IsRightToLeft;
    }
}