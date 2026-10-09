### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.comment"
	message = "This is a modified comment."
}

Update-MgBetaSecurityCaseManagementCaseActivity -CaseId $caseId -ActivityId $activityId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseManagementCaseActivity Cmdlet.

