### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	serverIds = @(
	"c0633ebb-8cfb-f17a-0b9e-83aa661f53a3"
)
}

Initialize-MgSecurityIdentitySensorCandidate -BodyParameter $params

```
This example shows how to use the Initialize-MgSecurityIdentitySensorCandidate Cmdlet.

