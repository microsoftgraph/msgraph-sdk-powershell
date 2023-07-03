### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseCustodian Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Email = "AdeleV@contoso.com"
	ApplyHoldToSources = "true"
}
New-MgBetaComplianceEdiscoveryCaseCustodian -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodian Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
