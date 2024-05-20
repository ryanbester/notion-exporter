using Microsoft.Extensions.Logging;

namespace NotionExporter.API
{
    public abstract class Module
    {
        /// <summary>
        /// Called when a module is first initialised; on program start up all when dynamically added in the Modules settings tab.
        /// </summary>
        /// <param name="logger">The logger instance to use when logging module events</param>
        /// <param name="instanceInfo">A class implemented IInstanceInfo, for querying various application parameters.</param>
        public abstract void InitModule(ILogger? logger, IInstanceInfo instanceInfo);

        /// <summary>
        /// Returns the name of the module.
        /// </summary>
        /// <returns>The name of the module</returns>
        public abstract string GetName();

        /// <summary>
        /// Returns the list of Notion block types the module processes.
        /// </summary>
        /// <returns>A string list of Notion block types</returns>
        public abstract List<string> GetProcessesList();

        /// <summary>
        /// Returns the SettingsManager instance.
        /// </summary>
        /// <returns>The SettingsManager instance.</returns>
        public abstract SettingsManager GetSettingsManager();
    }
}
