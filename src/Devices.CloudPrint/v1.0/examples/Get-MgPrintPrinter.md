### Example 1: Get a printer

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintPrinter -PrinterId $printerId

```
This example will get a printer

### Example 2: Get a printer and its capabilities

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintPrinter -PrinterId $printerId -Property "id,displayName,capabilities" 

```
This example will get a printer and its capabilities

