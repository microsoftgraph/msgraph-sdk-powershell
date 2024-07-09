### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	key = "key-value"
}

Invoke-MgBetaUploadTrustFrameworkKeySetCertificate -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaUploadTrustFrameworkKeySetCertificate Cmdlet.

