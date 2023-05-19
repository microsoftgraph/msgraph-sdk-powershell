### Example 1: Get a printer

```powershellImport-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintPrinter -PrinterId $printerId
```
This example shows how to use the Update-MgPrintPrinter Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a printer and its capabilities

```powershellImport-Module Microsoft.Graph.Devices.CloudPrint

Get-MgPrintPrinter -PrinterId $printerId -Property "id,displayName,capabilities"
```
This example shows how to use the Update-MgPrintPrinter Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

