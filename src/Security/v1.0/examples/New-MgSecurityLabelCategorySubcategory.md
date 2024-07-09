### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.subcategoryTemplate"
	displayName = "Vendor Invoice"
}

New-MgSecurityLabelCategorySubcategory -CategoryTemplateId $categoryTemplateId -BodyParameter $params

```
This example shows how to use the New-MgSecurityLabelCategorySubcategory Cmdlet.

