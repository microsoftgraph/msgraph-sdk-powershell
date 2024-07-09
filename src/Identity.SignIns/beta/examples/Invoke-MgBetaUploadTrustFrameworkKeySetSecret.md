### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	use = "use-value"
	k = "application-secret-to-be-uploaded"
	nbf = 1508969811
	exp = 1508973711
}

Invoke-MgBetaUploadTrustFrameworkKeySetSecret -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaUploadTrustFrameworkKeySetSecret Cmdlet.

