### Example 1: Create an assignment schedule request

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	accessId = "member"
	principalId = "3cce9d87-3986-4f19-8335-7ed075408ca2"
	groupId = "68e55cce-cf7e-4a2d-9046-3e4e75c4bfa7"
	action = "adminAssign"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2022-12-08T07:43:00.000Z")
		expiration = @{
			type = "afterDuration"
			duration = "PT2H"
		}
	}
	justification = "Assign active member access."
}

New-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest -BodyParameter $params

```
This example will create an assignment schedule request

### Example 2: User activates their eligible assignment for PIM for Groups

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	accessId = "member"
	principalId = "3cce9d87-3986-4f19-8335-7ed075408ca2"
	groupId = "2b5ed229-4072-478d-9504-a047ebd4b07d"
	action = "selfActivate"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2023-02-08T07:43:00.000Z")
		expiration = @{
			type = "afterDuration"
			duration = "PT2H"
		}
	}
	justification = "Activate assignment."
}

New-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest -BodyParameter $params

```
This example will user activates their eligible assignment for pim for groups

