
# Load the module dll
$null = Import-Module -Name (Join-Path $PSScriptRoot '.\artifacts\Microsoft.Graph.Authentication.dll')

if (Test-Path -Path "$PSScriptRoot\artifacts\StartupScripts" -ErrorAction Ignore)
{
    Get-ChildItem "$PSScriptRoot\artifacts\StartupScripts" -ErrorAction Stop | ForEach-Object {
        . $_.FullName
    }
}