### Example 1: Using the New-MgApplicationTokenLifetimePolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/policies/tokenLifetimePolicies/cd3d9b57-0aee-4f25-8ee3-ac74ef5986a9"
}
New-MgApplicationTokenLifetimePolicyByRef -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationTokenLifetimePolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
