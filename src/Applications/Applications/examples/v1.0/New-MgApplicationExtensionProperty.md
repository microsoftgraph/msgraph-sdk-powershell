###Example 1
```
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
