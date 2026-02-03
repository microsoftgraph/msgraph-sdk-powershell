### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	applyHoldToSources = "false"
}

Update-MgBetaComplianceEdiscoveryCaseCustodian -CaseId $caseId -CustodianId $custodianId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseCustodian Cmdlet.

