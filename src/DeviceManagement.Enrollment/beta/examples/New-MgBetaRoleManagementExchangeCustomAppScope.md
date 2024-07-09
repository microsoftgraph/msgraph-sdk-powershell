### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	type = "RecipientScope"
	displayName = "Protected Exec Users"
	customAttributes = @{
		Exclusive = $false
		RecipientFilter = "Title -like 'VP*'"
	}
}

New-MgBetaRoleManagementExchangeCustomAppScope -BodyParameter $params

```
This example shows how to use the New-MgBetaRoleManagementExchangeCustomAppScope Cmdlet.

