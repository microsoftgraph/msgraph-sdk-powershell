### Example 1: Using the Invoke-MgUploadTrustFrameworkKeySetPkcs12 Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Key = "Base64-encoded-pfx-content"
	Password = "password-value"
}
Invoke-MgUploadTrustFrameworkKeySetPkcs12 -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the Invoke-MgUploadTrustFrameworkKeySetPkcs12 Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
