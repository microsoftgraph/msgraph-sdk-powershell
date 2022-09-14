### Example 1: Using the New-MgPolicyPermissionGrantPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "my-custom-consent-policy"
	DisplayName = "Custom application consent policy"
	Description = "A custom permission grant policy to customize conditions for granting consent."
}
New-MgPolicyPermissionGrantPolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyPermissionGrantPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
