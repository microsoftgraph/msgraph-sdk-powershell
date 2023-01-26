### Example 1: Using the Update-MgBetaPolicyRoleManagementPolicyRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule"
	Id = "Expiration_EndUser_Assignment"
	IsExpirationRequired = $true
	MaximumDuration = "PT1H45M"
	Target = @{
		"@odata.type" = "microsoft.graph.unifiedRoleManagementPolicyRuleTarget"
		Caller = "EndUser"
		Operations = @(
			"All"
		)
		Level = "Assignment"
		InheritableSettings = @(
		)
		EnforcedSettings = @(
		)
	}
}
Update-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyRoleManagementPolicyRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
