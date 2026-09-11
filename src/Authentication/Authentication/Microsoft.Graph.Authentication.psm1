
# Load the module dll
$CoreAssemblyPath = (Join-Path $PSScriptRoot 'Microsoft.Graph.Authentication.Core.dll')
$ModulePath = (Join-Path $PSScriptRoot 'Microsoft.Graph.Authentication.dll')
[void][System.Reflection.Assembly]::LoadFrom($CoreAssemblyPath)
$ModuleAssembly = [System.Reflection.Assembly]::LoadFrom($ModulePath)
$ModuleInitializer = $ModuleAssembly.CreateInstance('Microsoft.Graph.PowerShell.Authentication.ModuleInitializer')

try {
    # Register dependency isolation before PowerShell scans the binary module's cmdlet types.
    $ModuleInitializer.OnImport()
    $null = Import-Module -Name $ModulePath -ErrorAction Stop
}
catch {
    $ModuleInitializer.OnRemove($null)
    throw
}
finally {
    Remove-Variable CoreAssemblyPath, ModuleAssembly, ModuleInitializer -ErrorAction Ignore
}

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
