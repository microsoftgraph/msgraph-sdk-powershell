### Example 1: Using the New-MgComplianceEdiscoveryCaseCustodian Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Email = "AdeleV@contoso.com"
	ApplyHoldToSources = "true"
}
New-MgComplianceEdiscoveryCaseCustodian -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseCustodian Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
