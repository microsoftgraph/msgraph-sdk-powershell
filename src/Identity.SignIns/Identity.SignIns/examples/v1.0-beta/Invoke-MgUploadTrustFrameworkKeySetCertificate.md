### Example 1: Using the Invoke-MgUploadTrustFrameworkKeySetCertificate Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Key = "key-value"
}
Invoke-MgUploadTrustFrameworkKeySetCertificate -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the Invoke-MgUploadTrustFrameworkKeySetCertificate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
