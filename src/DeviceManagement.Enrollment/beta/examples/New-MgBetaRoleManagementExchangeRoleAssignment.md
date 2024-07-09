### Example 1: Create a role assignment for Exchange Online provider with administrative unit scope

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	principalId = "/ServicePrincipals/0451dbb9-6336-42ea-b58f-5953dc053ece"
	roleDefinitionId = "f66ab1ee-3cac-4d03-8a64-dadc56e563f8"
	directoryScopeId = "/AdministrativeUnits/8b532c7a-4d3e-4e99-8ffa-2dfec92c62eb"
	appScopeId = $null
}

New-MgBetaRoleManagementExchangeRoleAssignment -BodyParameter $params

```
This example will create a role assignment for exchange online provider with administrative unit scope

