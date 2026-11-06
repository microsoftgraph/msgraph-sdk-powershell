### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	serverIds = @(
	"c0633ebb-8cfb-f17a-0b9e-83aa661f53a3"
)
}

Initialize-MgBetaSecurityIdentitySensorCandidate -BodyParameter $params

```
This example shows how to use the Initialize-MgBetaSecurityIdentitySensorCandidate Cmdlet.

