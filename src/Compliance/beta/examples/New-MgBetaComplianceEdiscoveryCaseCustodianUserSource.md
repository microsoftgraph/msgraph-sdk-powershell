### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	email = "megan@contoso.com"
	includedSources = "mailbox, site"
}

New-MgBetaComplianceEdiscoveryCaseCustodianUserSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodianUserSource Cmdlet.

