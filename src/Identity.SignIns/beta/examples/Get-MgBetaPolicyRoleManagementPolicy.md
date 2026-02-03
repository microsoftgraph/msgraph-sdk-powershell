### Example 1: Retrieve the details of a policy in PIM for Azure AD roles

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId

```
This example will retrieve the details of a policy in pim for azure ad roles

### Example 2: Retrieve the details of a policy in PIM for groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId

```
This example will retrieve the details of a policy in pim for groups

