### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Security

$params = @{
	site = @{
		webUrl = "https://m365x809305.sharepoint.com/sites/Retail"
	}
}

New-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

