### Example 1: Using the Invoke-MgUploadTrustFrameworkKeySetSecret Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Use = "use-value"
	K = "application-secret-to-be-uploaded"
	Nbf = 1508969811
	Exp = 1508973711
}
Invoke-MgUploadTrustFrameworkKeySetSecret -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the Invoke-MgUploadTrustFrameworkKeySetSecret Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
