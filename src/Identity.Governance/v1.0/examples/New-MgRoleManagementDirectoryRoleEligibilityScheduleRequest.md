### Example 1: Admin to assign a role eligibility schedule request

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	action = "adminAssign"
	justification = "Assign Attribute Assignment Admin eligibility to restricted user"
	roleDefinitionId = "8424c6f0-a189-499e-bbd0-26c1753c96d4"
	directoryScopeId = "/"
	principalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2022-04-10T00:00:00Z")
		expiration = @{
			type = "afterDateTime"
			endDateTime = [System.DateTime]::Parse("2024-04-10T00:00:00Z")
		}
	}
}

New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params

```
This example will admin to assign a role eligibility schedule request

### Example 2: Admin to remove an existing role eligibility schedule request

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	action = "adminRemove"
	roleDefinitionId = "8424c6f0-a189-499e-bbd0-26c1753c96d4"
	directoryScopeId = "/"
	principalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
}

New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params

```
This example will admin to remove an existing role eligibility schedule request

