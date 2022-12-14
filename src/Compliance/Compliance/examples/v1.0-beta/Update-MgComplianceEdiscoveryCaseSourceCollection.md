### Example 1: Using the Update-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "Quarterly Financials search"
}
Update-MgBetaComplianceEdiscoveryCaseSourceCollection -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
