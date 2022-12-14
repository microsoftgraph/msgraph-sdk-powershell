### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Email = "admin@M365x809305.onmicrosoft.com"
	IncludedSources = "mailbox, site"
}
New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Email = "admin@M365x809305.onmicrosoft.com"
	IncludedSources = "mailbox, site"
}
New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
