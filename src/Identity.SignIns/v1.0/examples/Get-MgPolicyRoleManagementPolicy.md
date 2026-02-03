### Example 1: Retrieve the details of a policy in PIM for Microsoft Entra roles

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId

```
This example will retrieve the details of a policy in pim for microsoft entra roles

### Example 2: Retrieve the details of a policy in PIM for Microsoft Entra roles and expand the relationships

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -ExpandProperty "effectiveRules,rules" 

```
This example will retrieve the details of a policy in pim for microsoft entra roles and expand the relationships

### Example 3: Retrieve the details of a policy in PIM for groups

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId

```
This example will retrieve the details of a policy in pim for groups

