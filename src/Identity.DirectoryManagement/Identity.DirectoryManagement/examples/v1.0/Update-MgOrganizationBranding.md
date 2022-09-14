### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	SignInPageText = "Default"
	UsernameHintText = "DefaultHint"
}
Update-MgOrganizationBranding -OrganizationId $organizationId -BodyParameter $params
```
