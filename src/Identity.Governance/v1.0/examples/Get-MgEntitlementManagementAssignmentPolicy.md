### Example 1: Retrieve a policy

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId

```
This example will retrieve a policy

### Example 2: Retrieve the custom extension stage settings for a policy

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -ExpandProperty "customExtensionStageSettings(`$expand=customExtension)" 

```
This example will retrieve the custom extension stage settings for a policy

