### Example 1: Using the New-MgBetaApplicationExtensionProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Name = "jobGroup"
	DataType = "String"
	TargetObjects = @(
		"User"
	)
}
New-MgBetaApplicationExtensionProperty -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgBetaApplicationExtensionProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
