### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/policies/tokenLifetimePolicies/4d2f137b-e8a9-46da-a5c3-cc85b2b840a4"
}

New-MgApplicationTokenLifetimePolicyByRef -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationTokenLifetimePolicyByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

