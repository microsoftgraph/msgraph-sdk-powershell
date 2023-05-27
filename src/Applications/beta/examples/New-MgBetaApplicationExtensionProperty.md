### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Applications

$params = @{
	name = "jobGroup"
	dataType = "String"
	targetObjects = @(
		"User"
	)
}

New-MgBetaApplicationExtensionProperty -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaApplicationExtensionProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

