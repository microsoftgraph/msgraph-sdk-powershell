### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.subcategoryTemplate"
	displayName = "Vendor Invoice"
}

New-MgBetaSecurityLabelCategorySubcategory -CategoryTemplateId $categoryTemplateId -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityLabelCategorySubcategory Cmdlet.

