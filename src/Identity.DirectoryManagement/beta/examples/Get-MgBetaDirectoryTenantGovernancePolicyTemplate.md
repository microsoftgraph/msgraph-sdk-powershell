### Example 1: Get a specific governance policy template

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryTenantGovernancePolicyTemplate -GovernancePolicyTemplateId $governancePolicyTemplateId

```
This example will get a specific governance policy template

### Example 2: Get the default governance policy template

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryTenantGovernancePolicyTemplate -GovernancePolicyTemplateId $governancePolicyTemplateId

```
This example will get the default governance policy template

