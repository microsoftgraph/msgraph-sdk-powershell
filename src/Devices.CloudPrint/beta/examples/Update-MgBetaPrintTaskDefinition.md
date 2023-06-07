### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	displayName = "Test TaskDefinitionName"
	createdBy = @{
		displayName = "Requesting App Display Name"
	}
}

Update-MgBetaPrintTaskDefinition -PrintTaskDefinitionId $printTaskDefinitionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrintTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

