REM Generates the licenses.json file for the installed NuGet packages

@ECHO off

WHERE dotnet-project-licenses >nul 2>nul
IF %ERRORLEVEL% NEQ 0 ECHO Install the dotnet-project-licenses tool with "dotnet tool install --global dotnet-project-licenses"

PUSHD ..\NotionExporter

ECHO Generating licenses.json...
dotnet-project-licenses.exe -i NotionExporter.csproj -o --outfile Resources/licenses.json -tj

POPD

ECHO Licenses.json generation complete
