### Example 1: Using the Update-MgComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	DisplayName = "Quarterly Financials search"
}
Update-MgComplianceEdiscoveryCaseSourceCollection -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
