### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Applications

$params = @{
	name = "jobGroup"
	dataType = "String"
	isMultiValued = $true
	targetObjects = @(
		"User"
	)
}

New-MgApplicationExtensionProperty -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationExtensionProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

