### Example 1: Using the Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12 Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Key = "Base64-encoded-pfx-content"
	Password = "password-value"
}
Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12 -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12 Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
