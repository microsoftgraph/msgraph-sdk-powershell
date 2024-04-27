### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	email = "AdeleV@contoso.com"
	applyHoldToSources = "true"
}

New-MgBetaComplianceEdiscoveryCaseCustodian -CaseId $caseId -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodian Cmdlet.

