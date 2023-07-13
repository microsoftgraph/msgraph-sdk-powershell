### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	status = @{
		state = "completed"
		description = "completed"
	}
}

Update-MgBetaPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId -PrintTaskId $printTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrintTaskDefinitionTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

