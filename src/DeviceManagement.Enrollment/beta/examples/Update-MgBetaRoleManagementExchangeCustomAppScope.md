### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	customAttributes = @{
		RecipientFilter = "City -eq 'Seattle'"
	}
}

Update-MgBetaRoleManagementExchangeCustomAppScope -CustomAppScopeId $customAppScopeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaRoleManagementExchangeCustomAppScope Cmdlet.

