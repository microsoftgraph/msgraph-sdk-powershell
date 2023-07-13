### Example 1: Using the Invoke-MgBetaUploadTrustFrameworkKeySetCertificate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Key = "key-value"
}
Invoke-MgBetaUploadTrustFrameworkKeySetCertificate -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaUploadTrustFrameworkKeySetCertificate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
