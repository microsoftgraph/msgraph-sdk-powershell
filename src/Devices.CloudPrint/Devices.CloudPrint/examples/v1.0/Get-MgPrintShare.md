### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare -PrinterShareId $printerShareId -Property "id,displayName,capabilities" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare -PrinterShareId $printerShareId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare
```
