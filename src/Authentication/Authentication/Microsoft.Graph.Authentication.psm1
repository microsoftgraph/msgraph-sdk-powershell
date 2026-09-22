
# On PowerShell 7+ set up the isolated AssemblyLoadContext *before* the module dll is loaded, so that
# Microsoft.Graph.Authentication.Core and its dependencies (Azure.Identity, MSAL, Kiota, ...) never bind into the
# default load context and cannot conflict with other modules. Windows PowerShell 5.1 has no load contexts, so there the
# dependencies are pre-loaded with Assembly.LoadFrom (the ModuleInitializer AssemblyResolve handler remains as a fallback).
$DependencyFolder = Join-Path $PSScriptRoot 'Dependencies'
if ($PSEdition -eq 'Core') {
    $CoreDependencyFolder = Join-Path $DependencyFolder 'Core'
    $LoaderPath = Join-Path $CoreDependencyFolder 'Microsoft.Graph.Authentication.Loader.dll'
    if (Test-Path -LiteralPath $LoaderPath) {
        $null = [System.Reflection.Assembly]::LoadFrom($LoaderPath)
        [Microsoft.Graph.PowerShell.Authentication.Loader.GraphLoadContextInitializer]::Initialize($DependencyFolder, $CoreDependencyFolder)
    }
}
else {
    $DesktopDependencyFolder = Join-Path $DependencyFolder 'Desktop'
    # Desktop first: it contains the net472-specific builds which must take precedence over the netstandard ones.
    $Loaded = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
    foreach ($Folder in @($DesktopDependencyFolder, $DependencyFolder)) {
        if (-not (Test-Path -LiteralPath $Folder)) { continue }
        foreach ($AssemblyFile in Get-ChildItem -LiteralPath $Folder -Filter '*.dll' -File) {
            if (-not $Loaded.Add($AssemblyFile.Name)) { continue }
            try {
                $null = [System.Reflection.Assembly]::LoadFrom($AssemblyFile.FullName)
            }
            catch {
                # Native or otherwise unloadable files are skipped; AssemblyResolve will handle anything still missing.
                Write-Debug "Skipped pre-loading '$($AssemblyFile.FullName)': $($_.Exception.Message)"
            }
        }
    }
}

# Load the module dll
$ModulePath = (Join-Path $PSScriptRoot 'Microsoft.Graph.Authentication.dll')
$null = Import-Module -Name $ModulePath

# Export nothing to clear implicit exports.
Export-ModuleMember

if (Test-Path -Path "$PSScriptRoot\StartupScripts" -ErrorAction Ignore)
{
    Get-ChildItem "$PSScriptRoot\StartupScripts" -Filter *.ps1 -ErrorAction Stop | ForEach-Object {
        . $_.FullName
    }
}

# Export binary module cmdlets.
Export-ModuleMember -Cmdlet (Get-ModuleCmdlet -ModulePath $ModulePath) -Alias (Get-ModuleCmdlet -ModulePath $ModulePath -AsAlias)
