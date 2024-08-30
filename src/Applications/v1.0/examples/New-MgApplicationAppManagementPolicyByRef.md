### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/policies/appManagementPolicies/{id}"
}

New-MgApplicationAppManagementPolicyByRef -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the New-MgApplicationAppManagementPolicyByRef Cmdlet.

