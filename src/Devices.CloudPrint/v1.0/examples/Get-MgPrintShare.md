### Example 1: Get a printerShare

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintShare -PrinterShareId $printerShareId

```
This example will get a printershare

### Example 2: Get a printerShare and its capabilities

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintShare -PrinterShareId $printerShareId -Property "id,displayName,capabilities" 

```
This example will get a printershare and its capabilities

