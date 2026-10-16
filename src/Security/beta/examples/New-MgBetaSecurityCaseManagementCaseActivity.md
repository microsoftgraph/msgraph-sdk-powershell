### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.comment"
	message = "This is a comment for the case."
}

New-MgBetaSecurityCaseManagementCaseActivity -CaseId $caseId -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityCaseManagementCaseActivity Cmdlet.

