###Example 1
```
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare -PrinterShareId $printerShareId -Property "id,displayName,capabilities" 
```
###Example 2
```
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare -PrinterShareId $printerShareId
```
###Example 3
```
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare
```
