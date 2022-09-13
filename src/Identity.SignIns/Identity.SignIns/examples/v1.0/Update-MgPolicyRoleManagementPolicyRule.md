###Example 1
```
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
