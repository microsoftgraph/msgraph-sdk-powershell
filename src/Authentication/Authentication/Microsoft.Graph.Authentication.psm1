
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
