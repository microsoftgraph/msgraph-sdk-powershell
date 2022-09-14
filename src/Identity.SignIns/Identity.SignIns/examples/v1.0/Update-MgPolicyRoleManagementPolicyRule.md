### Example 1: Using the Update-MgPolicyRoleManagementPolicyRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
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
Update-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyRoleManagementPolicyRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
