REM Generates pseudo-locales from the Resources.resx file

@ECHO off

WHERE pseudo-localize >nul 2>nul
IF %ERRORLEVEL% NEQ 0 ECHO Install the pseudo-localize tool with "dotnet tool install --global PseudoLocalize"

PUSHD ..\NotionExporter

ECHO Generating qps-Ploc locale...
pseudo-localize .\Properties\Resources.resx --culture qps-Ploc

ECHO Generating qps-Plocm locale...
pseudo-localize --mirror .\Properties\Resources.resx --culture qps-Plocm

POPD

ECHO Pseudo-locale generation complete
