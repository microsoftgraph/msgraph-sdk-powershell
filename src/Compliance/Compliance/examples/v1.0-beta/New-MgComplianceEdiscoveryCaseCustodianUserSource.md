### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseCustodianUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Email = "megan@contoso.com"
	IncludedSources = "mailbox, site"
}
New-MgBetaComplianceEdiscoveryCaseCustodianUserSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodianUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
