### Example 1: Update a rule defined for a policy in PIM for Microsoft Entra roles

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule"
	id = "Expiration_EndUser_Assignment"
	isExpirationRequired = $true
	maximumDuration = "PT1H45M"
	target = @{
		"@odata.type" = "microsoft.graph.unifiedRoleManagementPolicyRuleTarget"
		caller = "EndUser"
		operations = @(
			"All"
		)
		level = "Assignment"
		inheritableSettings = @(
		)
		enforcedSettings = @(
		)
	}
}

Update-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyRoleManagementPolicyRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Update a rule defined for a policy in PIM for groups

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule"
	id = "Expiration_EndUser_Assignment"
	isExpirationRequired = $true
	maximumDuration = "PT1H45M"
	target = @{
		caller = "EndUser"
		operations = @(
			"All"
		)
		level = "Assignment"
		inheritableSettings = @(
		)
		enforcedSettings = @(
		)
	}
}

Update-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyRoleManagementPolicyRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

