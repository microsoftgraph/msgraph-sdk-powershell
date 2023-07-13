### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Site = @{
		WebUrl = "https://m365x809305.sharepoint.com/sites/Retail"
	}
}
New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Site = @{
		WebUrl = "https://m365x809305.sharepoint.com/sites/Retail"
	}
}
New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
