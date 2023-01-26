### Example 1: Using the New-MgBetaApplicationAppManagementPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/policies/appManagementPolicies/{id}"
}
New-MgBetaApplicationAppManagementPolicyByRef -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgBetaApplicationAppManagementPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
