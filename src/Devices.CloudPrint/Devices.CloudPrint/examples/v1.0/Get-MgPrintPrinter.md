### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinter -PrinterId $printerId -Property "id,displayName,capabilities" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinter -PrinterId $printerId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinter
```
