### Example 1: List authorization systems onboarded to Permissions Management

```powershell

Import-Module Microsoft.Graph.Beta.Search

Get-MgBetaExternalAuthorizationSystem

```
This example will list authorization systems onboarded to permissions management

### Example 2: Identify all the authorization systems that are online and have permissions modification capability enabled

```powershell

Import-Module Microsoft.Graph.Beta.Search

Get-MgBetaExternalAuthorizationSystem -Filter "dataCollectionInfo/entitlements/microsoft.graph.entitlementsDataCollection/permissionsModificationCapability eq 'enabled' and dataCollectionInfo/entitlements/microsoft.graph.entitlementsDataCollection/status eq 'online'" 

```
This example will identify all the authorization systems that are online and have permissions modification capability enabled

