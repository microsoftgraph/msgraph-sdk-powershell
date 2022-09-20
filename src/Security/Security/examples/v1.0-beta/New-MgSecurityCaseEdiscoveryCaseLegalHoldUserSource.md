### Example 1: Using the New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Email = "admin@M365x809305.onmicrosoft.com"
	IncludedSources = "mailbox, site"
}
New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Email = "admin@M365x809305.onmicrosoft.com"
	IncludedSources = "mailbox, site"
}
New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
