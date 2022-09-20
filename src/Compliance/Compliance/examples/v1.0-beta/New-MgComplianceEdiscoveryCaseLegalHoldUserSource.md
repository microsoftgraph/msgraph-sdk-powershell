### Example 1: Using the New-MgComplianceEdiscoveryCaseLegalHoldUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Email = "adelev@contoso.com"
	IncludedSources = "mailbox"
}
New-MgComplianceEdiscoveryCaseLegalHoldUserSource -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseLegalHoldUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
