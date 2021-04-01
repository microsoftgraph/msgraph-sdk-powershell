
# Load the module dll
$null = Import-Module -Name (Join-Path $PSScriptRoot 'Microsoft.Graph.Authentication.dll')

if (Test-Path -Path "$PSScriptRoot\StartupScripts" -ErrorAction Ignore)
{
    Get-ChildItem "$PSScriptRoot\StartupScripts" -ErrorAction Stop | ForEach-Object {
        . $_.FullName
    }
}