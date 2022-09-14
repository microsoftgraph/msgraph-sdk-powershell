### Example 1
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinterTaskTrigger -PrinterId $printerId -PrintTaskTriggerId $printTaskTriggerId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinterTaskTrigger -PrinterId $printerId
```
