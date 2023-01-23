### Example 1: Using the New-MgBetaTrustFrameworkKeySetKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Use = "sig"
	Kty = "RSA"
	Nbf = 1508969811
	Exp = 1508969811
}
New-MgBetaTrustFrameworkKeySetKey -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params
```
This example shows how to use the New-MgBetaTrustFrameworkKeySetKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
