### Example 1: Using the New-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "microsoft.graph.appleManagedIdentityProvider"
	DisplayName = "Sign in with Apple"
	DeveloperId = "UBF8T346G9"
	ServiceId = "com.microsoft.rts.b2c.test.client"
	KeyId = "99P6D879C4"
	CertificateData = "******"
}
New-MgIdentityProvider -BodyParameter $params
```
This example shows how to use the New-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "microsoft.graph.identityProvider"
	Name = "Login with Amazon"
	Type = "Amazon"
	ClientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	ClientSecret = "000000000000"
}
New-MgIdentityProvider -BodyParameter $params
```
This example shows how to use the New-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "microsoft.graph.openIdConnectIdentityProvider"
	DisplayName = "Login with the Contoso identity provider"
	ClientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	ClientSecret = "12345"
	DomainHint = "mycustomoidc"
	MetadataUrl = "https://mycustomoidc.com/.well-known/openid-configuration"
	ResponseMode = "form_post"
	ResponseType = "code"
	Scope = "openid"
}
New-MgIdentityProvider -BodyParameter $params
```
This example shows how to use the New-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "microsoft.graph.openIdConnectProvider"
	Name = "Login with the Contoso identity provider"
	Type = "OpenIDConnect"
	ClientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	ClientSecret = "12345"
	DomainHint = "mycustomoidc"
	MetadataUrl = "https://mycustomoidc.com/.well-known/openid-configuration"
	ResponseMode = "form_post"
	ResponseType = "code"
	Scope = "openid"
}
New-MgIdentityProvider -BodyParameter $params
```
This example shows how to use the New-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "microsoft.graph.socialIdentityProvider"
	DisplayName = "Login with Amazon"
	IdentityProviderType = "Amazon"
	ClientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	ClientSecret = "000000000000"
}
New-MgIdentityProvider -BodyParameter $params
```
This example shows how to use the New-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
