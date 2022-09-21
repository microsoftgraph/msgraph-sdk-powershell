### Example 1: Using the New-MgComplianceEdiscoveryCaseCustodianUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Email = "megan@contoso.com"
	IncludedSources = "mailbox, site"
}
New-MgComplianceEdiscoveryCaseCustodianUserSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseCustodianUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
