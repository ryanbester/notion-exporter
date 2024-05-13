using Microsoft.Extensions.Logging;
using NotionExporter.Core.Logging;
using System.Reflection;
using Module = NotionExporter.API.Module;

namespace NotionExporter.Core
{
    internal static class Modules
    {
        public static readonly List<Module> BuiltInModules = [];
        public static readonly List<Module> ModulesList = [];

        public static void LoadModules()
        {
            ModulesList.Clear();

            var path = Path.Combine(Environment.CurrentDirectory, "modules");
            var files = Directory.GetFiles(path, "*.dll");

            var logger = Logger.Factory?.CreateLogger("Modules");
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
                            main.InitModule(Logger.Factory?.CreateLogger(type.FullName!));
                            var name = main.GetName();

                            logger?.LogInformation($"Loaded module {name}");

                            ModulesList.Add(main);

                            typeFound = true;
                            break;
                        }

                        if (!typeFound)
                        {
                            logger?.LogError("Module does not have a main class that extends NotionExporter.API.Module");
                        }

                    }
                    catch (Exception ex)
                    {
                        logger?.LogError(ex, "Failed to load module");
                    }
                }
            }
        }
    }
}