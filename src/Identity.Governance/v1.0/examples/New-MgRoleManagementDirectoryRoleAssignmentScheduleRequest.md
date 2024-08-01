### Example 1: Admin assigning a directory role to a principal

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	action = "adminAssign"
	justification = "Assign Groups Admin to IT Helpdesk group"
	roleDefinitionId = "fdd7a751-b60b-444a-984c-02652fe8fa1c"
	directoryScopeId = "/"
	principalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2022-04-10T00:00:00Z")
		expiration = @{
			type = "NoExpiration"
		}
	}
}

New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params

```
This example will admin assigning a directory role to a principal

### Example 2: User activating their eligible role

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	action = "selfActivate"
	principalId = "071cc716-8147-4397-a5ba-b2105951cc0b"
	roleDefinitionId = "8424c6f0-a189-499e-bbd0-26c1753c96d4"
	directoryScopeId = "/"
	justification = "I need access to the Attribute Administrator role to manage attributes to be assigned to restricted AUs"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2022-04-14T00:00:00.000Z")
		expiration = @{
			type = "AfterDuration"
			duration = "PT5H"
		}
	}
	ticketInfo = @{
		ticketNumber = "CONTOSO:Normal-67890"
		ticketSystem = "MS Project"
	}
}

New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params

```
This example will user activating their eligible role

