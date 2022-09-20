### Example 1: Using the Update-MgComplianceEdiscoveryCaseLegalHold Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Description = "This is a description for a legalHold"
}
Update-MgComplianceEdiscoveryCaseLegalHold -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseLegalHold Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
