### Example 1
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Action = "adminAssign"
	Justification = "Assign Attribute Assignment Admin eligibility to restricted user"
	RoleDefinitionId = "8424c6f0-a189-499e-bbd0-26c1753c96d4"
	DirectoryScopeId = "/"
	PrincipalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
	ScheduleInfo = @{
		StartDateTime = [System.DateTime]::Parse("2022-04-10T00:00:00Z")
		Expiration = @{
			Type = "afterDateTime"
			EndDateTime = [System.DateTime]::Parse("2024-04-10T00:00:00Z")
		}
	}
}
New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Action = "adminRemove"
	RoleDefinitionId = "8424c6f0-a189-499e-bbd0-26c1753c96d4"
	DirectoryScopeId = "/"
	PrincipalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
}
New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params
```
