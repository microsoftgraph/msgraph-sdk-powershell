### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

Get-MgBetaPrintShare -PrinterShareId $printerShareId -Property "id,displayName,capabilities"
```
This example shows how to use the Get-MgBetaPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

