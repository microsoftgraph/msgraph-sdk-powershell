### Example 1: Using the New-MgTrustFrameworkKeySetKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Use = "sig"
	Kty = "RSA"
	Nbf = 1508969811
	Exp = 1508969811
}
New-MgTrustFrameworkKeySetKey -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the New-MgTrustFrameworkKeySetKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
