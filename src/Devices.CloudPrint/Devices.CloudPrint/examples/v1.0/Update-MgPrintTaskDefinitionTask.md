### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	Status = @{
		State = "completed"
		Description = "completed"
	}
}
Update-MgPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId -PrintTaskId $printTaskId -BodyParameter $params
```
