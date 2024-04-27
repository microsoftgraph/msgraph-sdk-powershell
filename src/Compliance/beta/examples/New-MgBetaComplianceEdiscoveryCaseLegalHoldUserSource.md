### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	email = "adelev@contoso.com"
	includedSources = "mailbox"
}

New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource Cmdlet.

