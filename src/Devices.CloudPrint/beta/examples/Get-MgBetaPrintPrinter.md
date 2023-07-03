### Example 1: Get a printer

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

Get-MgBetaPrintPrinter -PrinterId $printerId
```
This example shows how to use the Get-MgBetaPrintPrinter Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a printer and its capabilities

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

Get-MgBetaPrintPrinter -PrinterId $printerId -Property "id,displayName,capabilities"
```
This example shows how to use the Get-MgBetaPrintPrinter Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

