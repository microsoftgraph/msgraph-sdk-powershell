### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	displayName = "Contoso Install Site"
	webUrl = "http://www.contoso.com/"
	description = "Try or buy Contoso for Home or Business and view product information"
	keywords = @{
		keywords = @(
		"Contoso"
	"install"
)
reservedKeywords = @(
"Contoso"
)
matchSimilarKeywords = $true
}
availabilityStartDateTime = $null
availabilityEndDateTime = $null
platforms = @(
"windows"
)
targetedVariations = @(
@{
languageTag = "es-es"
displayName = "Sitio de instalación Contoso"
description = "Pruebe o compre Contoso hogar o negocios y vea la información del producto"
}
)
state = "published"
}

New-MgBetaSearchBookmark -BodyParameter $params

```
This example shows how to use the New-MgBetaSearchBookmark Cmdlet.

