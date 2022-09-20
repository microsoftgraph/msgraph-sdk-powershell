### Example 1: Using the New-MgComplianceEdiscoveryCaseLegalHold Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
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
New-MgComplianceEdiscoveryCaseLegalHold -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseLegalHold Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
