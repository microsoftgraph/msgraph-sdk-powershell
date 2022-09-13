###Example 1
```
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinter -PrinterId $printerId -Property "id,displayName,capabilities" 
```
###Example 2
```
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinter -PrinterId $printerId
```
###Example 3
```
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintPrinter
```
