### Example 1: Retrieve an application by its appId and only specific properties

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplicationByAppId -Property "id,appId,displayName,requiredResourceAccess" 

```
This example will retrieve an application by its appid and only specific properties

