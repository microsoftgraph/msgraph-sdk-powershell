### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "microsoft.graph.security.siteSource"
	site = @{
		webUrl = "https://m365x809305.sharepoint.com/sites/Design-topsecret"
	}
}

New-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource Cmdlet.

