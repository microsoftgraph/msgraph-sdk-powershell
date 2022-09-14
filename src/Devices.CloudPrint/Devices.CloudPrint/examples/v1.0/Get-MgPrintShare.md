### Example 1: Using the Get-MgPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare -PrinterShareId $printerShareId -Property "id,displayName,capabilities" 
```
This example shows how to use the Get-MgPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare -PrinterShareId $printerShareId
```
This example shows how to use the Get-MgPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Get-MgPrintShare
```
This example shows how to use the Get-MgPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
