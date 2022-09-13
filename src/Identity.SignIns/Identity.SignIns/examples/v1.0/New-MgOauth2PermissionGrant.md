###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	ClientId = "ef969797-201d-4f6b-960c-e9ed5f31dab5"
	ConsentType = "AllPrincipals"
	ResourceId = "943603e4-e787-4fe9-93d1-e30f749aae39"
	Scope = "DelegatedPermissionGrant.ReadWrite.All"
}
New-MgOauth2PermissionGrant -BodyParameter $params
```
