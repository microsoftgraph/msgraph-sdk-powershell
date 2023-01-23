### Example 1: Using the New-MgPrintTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "Test TaskDefinitionName"
	CreatedBy = @{
		DisplayName = "Requesting App Display Name"
	}
}
New-MgPrintTaskDefinition -BodyParameter $params
```
This example shows how to use the New-MgPrintTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
