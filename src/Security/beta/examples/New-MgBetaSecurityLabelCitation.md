### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.citationTemplate"
	displayName = "Contoso Company Policy"
	citationUrl = "www.citationUrl.com"
	citationJurisdiction = "Contoso"
}

New-MgBetaSecurityLabelCitation -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityLabelCitation Cmdlet.

