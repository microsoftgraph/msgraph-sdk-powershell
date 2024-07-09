### Example 1: Admin to assign a role eligibility schedule request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	action = "AdminAssign"
	justification = "Assign User Admin eligibility to IT Helpdesk (User) group"
	roleDefinitionId = "fdd7a751-b60b-444a-984c-02652fe8fa1c"
	directoryScopeId = "/"
	principalId = "07706ff1-46c7-4847-ae33-3003830675a1"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2021-07-01T00:00:00Z")
		expiration = @{
			endDateTime = [System.DateTime]::Parse("2022-06-30T00:00:00Z")
			type = "AfterDateTime"
		}
	}
}

New-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params

```
This example will admin to assign a role eligibility schedule request

### Example 2: Admin to remove an existing role eligibility schedule request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	action = "AdminRemove"
	justification = "Assign User Admin eligibility to IT Helpdesk (User) group"
	roleDefinitionId = "fdd7a751-b60b-444a-984c-02652fe8fa1c"
	directoryScopeId = "/"
	principalId = "07706ff1-46c7-4847-ae33-3003830675a1"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2021-07-26T18:08:06.2081758Z")
		expiration = @{
			endDateTime = [System.DateTime]::Parse("2022-06-30T00:00:00Z")
			type = "AfterDateTime"
		}
	}
}

New-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params

```
This example will admin to remove an existing role eligibility schedule request

