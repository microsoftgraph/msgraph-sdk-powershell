### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -ExpandProperty "effectiveRules,rules"
```
This example shows how to use the Get-MgBetaPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

