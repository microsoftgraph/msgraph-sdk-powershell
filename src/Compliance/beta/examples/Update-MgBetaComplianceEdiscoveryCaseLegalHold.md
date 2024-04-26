### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	description = "This is a description for a legalHold"
}

Update-MgBetaComplianceEdiscoveryCaseLegalHold -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseLegalHold Cmdlet.

