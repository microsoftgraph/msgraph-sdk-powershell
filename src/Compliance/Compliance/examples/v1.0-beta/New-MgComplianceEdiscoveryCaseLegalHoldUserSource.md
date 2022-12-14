### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Email = "adelev@contoso.com"
	IncludedSources = "mailbox"
}
New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
