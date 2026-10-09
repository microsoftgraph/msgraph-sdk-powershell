### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.task"
	displayName = "Validate affected devices"
	status = "new"
	description = "Review affected devices and collect evidence"
	assignedTo = "user@contoso.com"
	closingNotes = "Investigation completed and documented"
	dueDateTime = [System.DateTime]::Parse("2026-06-29T17:54:43Z")
	priority = "high"
	category = "investigate"
}

Update-MgBetaSecurityCaseManagementCaseTask -CaseId $caseId -TaskId $taskId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseManagementCaseTask Cmdlet.

