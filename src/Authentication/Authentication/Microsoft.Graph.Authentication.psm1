
# Load the module dll
$null = Import-Module -Name (Join-Path $PSScriptRoot 'Microsoft.Graph.Authentication.dll')

if (Test-Path -Path "$PSScriptRoot\StartupScripts" -ErrorAction Ignore)
{
    Get-ChildItem "$PSScriptRoot\StartupScripts" -ErrorAction Stop | ForEach-Object {
        . $_.FullName
    }
}

$DependencyPath = (Join-Path $PSScriptRoot -ChildPath "Dependencies")
if (Test-Path $DependencyPath -ErrorAction Ignore)
{
    try
    {
        Get-ChildItem -ErrorAction Stop -Path $DependencyPath -Filter "*.dll" | ForEach-Object {
            try
            {
                Add-Type -Path $_.FullName -ErrorAction Ignore | Out-Null
            }
            catch {
                Write-Verbose $_
            }
        }
    }
    catch {}
}