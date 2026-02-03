### Example 1: List microsoft.directory actions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction -UnifiedRbacResourceNamespaceId $unifiedRbacResourceNamespaceId

```
This example will list microsoft.directory actions

### Example 2: List microsoft.insights actions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction -UnifiedRbacResourceNamespaceId $unifiedRbacResourceNamespaceId

```
This example will list microsoft.insights actions

### Example 3: List privileged actions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction -UnifiedRbacResourceNamespaceId $unifiedRbacResourceNamespaceId -Filter "isPrivileged eq true" 

```
This example will list privileged actions

