### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Devices.CloudPrint

$params = @{
	status = @{
		state = "completed"
		description = "completed"
	}
}

Update-MgPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId -PrintTaskId $printTaskId -BodyParameter $params
```
This example shows how to use the Get-MgPrintTaskDefinitionTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

