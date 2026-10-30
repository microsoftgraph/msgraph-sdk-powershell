### Example 1: Update a generic case

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.genericCase"
	displayName = "Case MS-001"
	status = "Open"
	description = "Investigating potential credential compromise."
	assignedTo = "john.doe@contoso.com"
	priority = "high"
	dueDateTime = "2026-06-29T17:54:43Z"
	closingNotes = "Follow up with the account owner."
	customFields = @{
		"Customer impact" = @{
			"@odata.type" = "#microsoft.graph.security.caseManagement.customFieldStringValue"
			value = "Multiple executive mailboxes affected"
		}
	}
}

Update-MgBetaSecurityCaseManagementCase -CaseId $caseId -BodyParameter $params

```
This example will update a generic case

### Example 2: Update synchronized incident case properties

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.incidentCase"
	displayName = "Incident Case MS-002"
	status = "InProgress"
	classification = "truePositive"
	determination = "phishing"
	severity = "high"
}

Update-MgBetaSecurityCaseManagementCase -CaseId $caseId -BodyParameter $params

```
This example will update synchronized incident case properties

