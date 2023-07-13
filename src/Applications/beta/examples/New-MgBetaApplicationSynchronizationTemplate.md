### Example 1: Using the New-MgBetaApplicationSynchronizationTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Id = "SCIM-Test1"
	ApplicationId = "{id}"
	FactoryTag = "CustomSCIM"
}
New-MgBetaApplicationSynchronizationTemplate -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgBetaApplicationSynchronizationTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
