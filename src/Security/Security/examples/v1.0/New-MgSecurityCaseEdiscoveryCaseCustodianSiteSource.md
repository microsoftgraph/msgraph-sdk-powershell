###Example 1
```
Import-Module Microsoft.Graph.Security
$params = @{
	Site = @{
		WebUrl = "https://m365x809305.sharepoint.com/sites/Retail"
	}
}
New-MgSecurityCaseEdiscoveryCaseCustodianSiteSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
