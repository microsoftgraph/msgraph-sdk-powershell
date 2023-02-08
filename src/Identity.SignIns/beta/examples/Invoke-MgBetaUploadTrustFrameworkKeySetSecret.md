### Example 1: Using the Invoke-MgBetaUploadTrustFrameworkKeySetSecret Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Use = "use-value"
	K = "application-secret-to-be-uploaded"
	Nbf = 1508969811
	Exp = 1508973711
}
Invoke-MgBetaUploadTrustFrameworkKeySetSecret -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaUploadTrustFrameworkKeySetSecret Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
