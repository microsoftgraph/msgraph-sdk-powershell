### Example 1: Using the New-MgBetaPrintTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
$params = @{
	DisplayName = "Test TaskDefinitionName"
	CreatedBy = @{
		DisplayName = "Requesting App Display Name"
	}
}
New-MgBetaPrintTaskDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaPrintTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
