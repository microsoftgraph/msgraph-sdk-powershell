### Example 1: Admin assigning a directory role to a principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	action = "AdminAssign"
	justification = "Assign User Admin to IT Helpdesk (User) group"
	roleDefinitionId = "fdd7a751-b60b-444a-984c-02652fe8fa1c"
	directoryScopeId = "/"
	principalId = "07706ff1-46c7-4847-ae33-3003830675a1"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2021-07-01T00:00:00Z")
		expiration = @{
			type = "NoExpiration"
		}
	}
}

New-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params

```
This example will admin assigning a directory role to a principal

### Example 2: User activating their eligible role

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	action = "SelfActivate"
	principalId = "c6ad1942-4afa-47f8-8d48-afb5d8d69d2f"
	roleDefinitionId = "9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
	directoryScopeId = "/"
	justification = "Need to update app roles for selected apps."
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2021-08-17T17:40:00.000Z")
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

New-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params

```
This example will user activating their eligible role

