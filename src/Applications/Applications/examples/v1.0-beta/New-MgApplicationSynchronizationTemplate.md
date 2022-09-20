### Example 1: Using the New-MgApplicationSynchronizationTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Id = "SCIM-Test1"
	ApplicationId = "{id}"
	FactoryTag = "CustomSCIM"
}
New-MgApplicationSynchronizationTemplate -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationSynchronizationTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
