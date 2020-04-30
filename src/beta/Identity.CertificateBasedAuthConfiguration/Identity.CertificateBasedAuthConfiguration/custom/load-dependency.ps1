# Ensures 'Graph.Authentication' module is always loaded before this module is loaded.
$ErrorActionPreference = "Stop"
$RequiredModules = "Microsoft.Graph.Authentication"

$Module = Get-Module $RequiredModules
if ($null -eq $Module) 
{ 
    Import-Module $RequiredModules -Scope Global
}
