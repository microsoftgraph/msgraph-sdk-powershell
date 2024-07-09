### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	name = "jobGroup"
	dataType = "String"
	isMultiValued = $true
	targetObjects = @(
	"User"
)
}

New-MgBetaApplicationExtensionProperty -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the New-MgBetaApplicationExtensionProperty Cmdlet.

