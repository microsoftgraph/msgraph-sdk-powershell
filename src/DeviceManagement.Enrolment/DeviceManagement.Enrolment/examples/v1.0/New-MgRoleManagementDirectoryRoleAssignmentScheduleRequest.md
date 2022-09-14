### Example 1: Using the New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Action = "adminAssign"
	Justification = "Assign Groups Admin to IT Helpdesk group"
	RoleDefinitionId = "fdd7a751-b60b-444a-984c-02652fe8fa1c"
	DirectoryScopeId = "/"
	PrincipalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
	ScheduleInfo = @{
		StartDateTime = [System.DateTime]::Parse("2022-04-10T00:00:00Z")
		Expiration = @{
			Type = "NoExpiration"
		}
	}
}
New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Action = "selfActivate"
	PrincipalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
	RoleDefinitionId = "8424c6f0-a189-499e-bbd0-26c1753c96d4"
	DirectoryScopeId = "/"
	Justification = "I need access to the Attribute Administrator role to manage attributes to be assigned to restricted AUs"
	ScheduleInfo = @{
		StartDateTime = [System.DateTime]::Parse("2022-04-14T00:00:00.000Z")
		Expiration = @{
			Type = "AfterDuration"
			Duration = "PT5H"
		}
	}
	TicketInfo = @{
		TicketNumber = "CONTOSO:Normal-67890"
		TicketSystem = "MS Project"
	}
}
New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
