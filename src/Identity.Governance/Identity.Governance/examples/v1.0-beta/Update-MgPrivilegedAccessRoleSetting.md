### Example 1: Using the Update-MgBetaPrivilegedAccessRoleSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	AdminEligibleSettings = @(
		@{
			RuleIdentifier = "ExpirationRule"
			Setting = "{"permanentAssignment":false,"maximumGrantPeriodInMinutes":129600}"
		}
	)
}
Update-MgBetaPrivilegedAccessRoleSetting -PrivilegedAccessId $privilegedAccessId -GovernanceRoleSettingId $governanceRoleSettingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrivilegedAccessRoleSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
