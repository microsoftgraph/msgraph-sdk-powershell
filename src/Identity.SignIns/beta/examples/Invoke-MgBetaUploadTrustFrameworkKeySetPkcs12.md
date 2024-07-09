### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	key = "Base64-encoded-pfx-content"
	password = "password-value"
}

Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12 -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12 Cmdlet.

