### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.incidentRelation"
	relatedResourceId = "987654321"
}

New-MgBetaSecurityCaseManagementCaseRelation -CaseId $caseId -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityCaseManagementCaseRelation Cmdlet.

