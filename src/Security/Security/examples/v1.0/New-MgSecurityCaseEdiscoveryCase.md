### Example 1
``` powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "CONTOSO LITIGATION-005"
	Description = "Project Bazooka"
	ExternalId = "324516"
}
New-MgSecurityCaseEdiscoveryCase -BodyParameter $params
```
