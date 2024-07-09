### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

$params = @{
	displayName = "Production Site List A"
	description = "Production site list for team A"
}

New-MgBetaAdminEdgeInternetExplorerModeSiteList -BodyParameter $params

```
This example shows how to use the New-MgBetaAdminEdgeInternetExplorerModeSiteList Cmdlet.

