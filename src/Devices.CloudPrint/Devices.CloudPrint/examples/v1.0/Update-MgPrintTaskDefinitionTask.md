### Example 1: Using the Update-MgPrintTaskDefinitionTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	Status = @{
		State = "completed"
		Description = "completed"
	}
}
Update-MgPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId -PrintTaskId $printTaskId -BodyParameter $params
```
This example shows how to use the Update-MgPrintTaskDefinitionTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
