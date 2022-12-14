### Example 1: Using the Update-MgBetaComplianceEdiscoveryCaseCustodian Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	ApplyHoldToSources = "false"
}
Update-MgBetaComplianceEdiscoveryCaseCustodian -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseCustodian Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
