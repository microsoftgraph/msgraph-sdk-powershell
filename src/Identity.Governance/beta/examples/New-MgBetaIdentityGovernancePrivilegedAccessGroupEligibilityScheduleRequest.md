### Example 1: An admin creates an eligible group ownership request for a principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	accessId = "member"
	principalId = "3cce9d87-3986-4f19-8335-7ed075408ca2"
	groupId = "2b5ed229-4072-478d-9504-a047ebd4b07d"
	action = "AdminAssign"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2023-02-06T19:25:00.000Z")
		expiration = @{
			type = "AfterDateTime"
			endDateTime = [System.DateTime]::Parse("2023-02-07T19:56:00.000Z")
		}
	}
	justification = "Assign eligible request."
}

New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest -BodyParameter $params

```
This example will an admin creates an eligible group ownership request for a principal

### Example 2: An admin extends an eligible group membership for a principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	accessId = "member"
	principalId = "3cce9d87-3986-4f19-8335-7ed075408ca2"
	groupId = "2b5ed229-4072-478d-9504-a047ebd4b07d"
	action = "AdminExtend"
	scheduleInfo = @{
		startDateTime = [System.DateTime]::Parse("2023-02-06T19:25:00.000Z")
		expiration = @{
			type = "AfterDateTime"
			endDateTime = [System.DateTime]::Parse("2023-02-07T20:56:00.000Z")
		}
	}
	justification = "Extend eligible request."
}

New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest -BodyParameter $params

```
This example will an admin extends an eligible group membership for a principal

