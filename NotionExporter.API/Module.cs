using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

[assembly: InternalsVisibleTo("NotionExporter")]

namespace NotionExporter.API
{
    public abstract class Module
    {
        /// <summary>
        /// True if the module is a built-in module.
        /// Built-in modules cannot be disabled by the user.
        /// </summary>
        public bool BuiltIn { get; internal set; }

        /// <summary>
        /// True if the module has been disabled by the user.
        /// </summary>
        public bool Disabled { get; internal set; }

        /// <summary>
        /// Stores the full path of the DLL when the plugin is loaded.
        /// </summary>
        internal string FullPath { get; set; }

        /// <summary>
        /// Returns the value of <c>GetName()</c>.
        /// Used for the <c>DisplayMember</c> property.
        /// </summary>
        public string Name => GetName();

        /// <summary>
        /// Returns the name of the module.
        /// </summary>
        /// <returns>The name of the module</returns>
        public abstract string GetName();

        /// <summary>
        /// Returns the metadata of the module.
        /// </summary>
        /// <returns>The metadata of the module</returns>
        public abstract ModuleMetadata GetMetadata();

        /// <summary>
        /// Returns the list of Notion block types the module processes.
        /// </summary>
        /// <returns>A string list of Notion block types</returns>
        public abstract IEnumerable<string> GetProcessesList();

        /// <summary>
        /// Called when a module is first initialised; on program start up or when dynamically added in the Modules settings tab.
        /// This method is also called if a module is disabled, be sure to query the <c>Disabled</c> property.
        /// </summary>
        /// <param name="logger">The logger instance to use when logging module events</param>
        /// <param name="instanceInfo">A class implemented IInstanceInfo, for querying various application parameters.</param>
        public abstract void InitModule(ILogger? logger, IInstanceInfo instanceInfo);

        /// <summary>
        /// Called when a module has been enabled by the user.
        /// This method is not called when a plugin is first installed.
        /// </summary>
        public virtual void OnEnable()
        {
        }

        /// <summary>
        /// Called when a module has been disabled by the user.
        /// This method is not called when a plugin is uninstalled.
        /// </summary>
        public virtual void OnDisable()
        {
        }

        /// <summary>
        /// Returns the SettingsManager instance.
        /// </summary>
        /// <returns>The SettingsManager instance.</returns>
        public abstract SettingsManager GetSettingsManager();
    }

    public class ModuleMetadata(Version version)
    {
        public Version Version { get; set; } = version;
        public List<string> Authors { get; set; } = [];
        public string Description { get; set; } = string.Empty;
        public string Webpage { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Issues { get; set; } = string.Empty;
        public string License { get; set; } = string.Empty;
    }
}