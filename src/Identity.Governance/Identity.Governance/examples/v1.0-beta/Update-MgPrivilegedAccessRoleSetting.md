### Example 1: Using the Update-MgPrivilegedAccessRoleSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	AdminEligibleSettings = @(
		@{
			RuleIdentifier = "ExpirationRule"
			Setting = "{"permanentAssignment":false,"maximumGrantPeriodInMinutes":129600}"
		}
	)
}
Update-MgPrivilegedAccessRoleSetting -PrivilegedAccessId $privilegedAccessId -GovernanceRoleSettingId $governanceRoleSettingId -BodyParameter $params
```
This example shows how to use the Update-MgPrivilegedAccessRoleSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
