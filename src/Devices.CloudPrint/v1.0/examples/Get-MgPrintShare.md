### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintShare -PrinterShareId $printerShareId -Property "id,displayName,capabilities" 

```
This example shows how to use the Get-MgPrintShare Cmdlet.

