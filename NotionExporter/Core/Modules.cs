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
                       }))
                {
                    logger?.LogInformation("Loading built-in module");

                    try
                    {
                        module.InitModule(Logger.Factory?.CreateLogger(className!), InstanceInfo);
                        var name = module.GetName();
                        
                        logger?.LogInformation("Loading settings for built-in module");
                        LoadModuleSettings(module, className!);

                        logger?.LogInformation($"Loaded built-in module {name}");

                        ModulesList.Add(module);
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
                       }))
                {
                    logger?.LogInformation("Loading module");

                    try
                    {
                        var dll = Assembly.LoadFile(file);

                        var typeFound = false;
                        foreach (var type in dll.GetExportedTypes())
                        {
                            if (!type.IsSubclassOf(typeof(Module))) continue;

                            logger?.LogInformation($"Found module main class to be {type.Name}");

                            var main = (Module)Activator.CreateInstance(type)!;
                            main.InitModule(Logger.Factory?.CreateLogger(type.FullName!), InstanceInfo);
                            var name = main.GetName();
                            
                            logger?.LogInformation("Loading settings for module");
                            LoadModuleSettings(main, type.FullName!);

                            logger?.LogInformation($"Loaded module {name}");

                            ModulesList.Add(main);

                            typeFound = true;
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
    }

    internal class InstanceInfo : IInstanceInfo
    {
        public bool IsBuiltInProfile()
        {
            return AppContext.CurrentProfile.BuiltIn;
        }
    }
}