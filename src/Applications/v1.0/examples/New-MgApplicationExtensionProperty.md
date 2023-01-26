### Example 1: Using the New-MgApplicationExtensionProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Name = "jobGroup"
	DataType = "String"
	TargetObjects = @(
		"User"
	)
}
New-MgApplicationExtensionProperty -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationExtensionProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
