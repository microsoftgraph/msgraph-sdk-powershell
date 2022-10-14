### Example 1: Using the New-MgPolicyClaimMappingPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Definition = @(
		"{"ClaimsMappingPolicy":{"Version":1,"IncludeBasicClaimSet":"true","ClaimsSchema": [{"Source":"user","ID":"userprincipalname","SamlClaimType":"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"},{"Source":"user","ID":"givenname","SamlClaimType":"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname"},{"Source":"user","ID":"displayname","SamlClaimType":"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"},{"Source":"user","ID":"surname","SamlClaimType":"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname"},{"Source":"user","ID":"userprincipalname","SamlClaimType":"username"}],"ClaimsTransformation":[{"ID":"CreateTermsOfService","TransformationMethod":"CreateStringClaim","InputParameters": [{"ID":"value","DataType":"string", "Value":"sandbox"}],"OutputClaims":[{"ClaimTypeReferenceId":"TOS","TransformationClaimType":"createdClaim"}]}]}}"
	)
	DisplayName = "Test1234"
}
New-MgPolicyClaimMappingPolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyClaimMappingPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
