# Load dependencies
$preloadPath = (Join-Path $PSScriptRoot -ChildPath ".\bin\PreloadAssemblies")
if ($PSEdition -eq 'Desktop' -and (Test-Path $preloadPath -ErrorAction Ignore)) {
    try {
        Get-ChildItem -ErrorAction Stop -Path $preloadPath -Filter "*.dll" | ForEach-Object {
            Add-Type -Path $_.FullName -ErrorAction Ignore | Out-Null
        }
    }
    catch { }
}

# Load the module dll
$null = Import-Module -Name (Join-Path $PSScriptRoot '.\bin\Microsoft.Graph.Authentication.dll')