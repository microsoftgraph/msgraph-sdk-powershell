### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId -PrintTaskId $printTaskId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId
```
