### Example 1: Retrieve a service principal by its appId and only specific properties

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipalByAppId -Property "id,appId,displayName,appRoles,publishedPermissionScopes,resourceSpecificApplicationPermissions" 

```
This example will retrieve a service principal by its appid and only specific properties

