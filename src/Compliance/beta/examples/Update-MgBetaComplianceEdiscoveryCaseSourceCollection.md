### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	displayName = "Quarterly Financials search"
}

Update-MgBetaComplianceEdiscoveryCaseSourceCollection -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet.

