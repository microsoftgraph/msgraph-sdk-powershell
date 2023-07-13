### Example 1: Using the Update-MgBetaComplianceEdiscoveryCaseLegalHold Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Description = "This is a description for a legalHold"
}
Update-MgBetaComplianceEdiscoveryCaseLegalHold -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseLegalHold Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
