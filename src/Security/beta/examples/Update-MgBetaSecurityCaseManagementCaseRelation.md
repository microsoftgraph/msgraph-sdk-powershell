### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.incidentRelation"
	relatedResourceId = "987654321"
}

Update-MgBetaSecurityCaseManagementCaseRelation -CaseId $caseId -RelationId $relationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseManagementCaseRelation Cmdlet.

