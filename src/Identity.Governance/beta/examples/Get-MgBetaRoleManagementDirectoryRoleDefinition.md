### Example 1: List role definitions for a directory provider

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleDefinition

```
This example will list role definitions for a directory provider

### Example 2: List privileged role definitions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleDefinition -Filter "isPrivileged eq true" 

```
This example will list privileged role definitions

