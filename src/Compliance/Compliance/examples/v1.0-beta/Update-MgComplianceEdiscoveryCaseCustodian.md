### Example 1: Using the Update-MgComplianceEdiscoveryCaseCustodian Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	ApplyHoldToSources = "false"
}
Update-MgComplianceEdiscoveryCaseCustodian -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseCustodian Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
