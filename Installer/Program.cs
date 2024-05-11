using System.Runtime.CompilerServices;
using WixSharp;

[assembly: InternalsVisibleTo(assemblyName: "Installer.aot")]

const string productName = "Notion Exporter";
const string internalName = "NotionExporter";
const string publishDir = $@"..\{internalName}\bin\Release\net6.0-windows\publish\*";
const string localAppDataDir = $@"%LocalAppData%\{internalName}";

var project = new ManagedProject(productName,
    new Dir(localAppDataDir, new Files(publishDir)),
    new Dir("%ProgramMenu%", new ExeFileShortcut(productName, $"[INSTALLDIR]{internalName}.exe", "")))
{
    Scope = InstallScope.perUser,
    LicenceFile = @"..\LICENSE.rtf",
    UI = WUI.WixUI_InstallDir
};

project.Include(WixExtension.NetFx);
project.BuildMsi();
