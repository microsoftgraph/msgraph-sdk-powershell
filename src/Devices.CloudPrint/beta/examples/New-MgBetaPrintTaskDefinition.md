### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	displayName = "Test TaskDefinitionName"
	createdBy = @{
		displayName = "Requesting App Display Name"
	}
}

New-MgBetaPrintTaskDefinition -BodyParameter $params

```
This example shows how to use the New-MgBetaPrintTaskDefinition Cmdlet.

