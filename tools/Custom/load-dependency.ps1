# Ensures 'Graph.Authentication' module is always loaded before this module is loaded.
$ErrorActionPreference = "Stop"
$RequiredModules = "Graph.Authentication"

$Module = Get-Module $RequiredModules
if ($Module -eq $null) 
{ 
    Import-Module $RequiredModules -Scope Global
    # Graph.Authentication -MinimumVersion 0.0.0.1 -Scope Global
}
