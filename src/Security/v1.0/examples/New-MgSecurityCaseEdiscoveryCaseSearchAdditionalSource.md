### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "microsoft.graph.security.siteSource"
}

New-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource Cmdlet.

