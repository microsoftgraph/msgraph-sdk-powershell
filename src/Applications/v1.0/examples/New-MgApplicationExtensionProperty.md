### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	name = "jobGroup"
	dataType = "String"
	targetObjects = @(
		"User"
	)
}

New-MgApplicationExtensionProperty -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the New-MgApplicationExtensionProperty Cmdlet.

