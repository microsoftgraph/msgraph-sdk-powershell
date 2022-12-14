### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseLegalHold Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	"@odata.type" = "#microsoft.graph.ediscovery.legalHold"
	Description = "String"
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	IsEnabled = "Boolean"
	Status = "String"
	ContentQuery = "String"
	Errors = @(
		"String"
	)
	DisplayName = "String"
}
New-MgBetaComplianceEdiscoveryCaseLegalHold -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseLegalHold Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
