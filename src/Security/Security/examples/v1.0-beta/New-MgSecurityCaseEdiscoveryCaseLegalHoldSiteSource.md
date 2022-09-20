### Example 1: Using the New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Site = @{
		WebUrl = "https://m365x809305.sharepoint.com/sites/Retail"
	}
}
New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Site = @{
		WebUrl = "https://m365x809305.sharepoint.com/sites/Retail"
	}
}
New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
