### Example 1: Using the New-MgApplicationAppManagementPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/policies/appManagementPolicies/{id}"
}
New-MgApplicationAppManagementPolicyByRef -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationAppManagementPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
