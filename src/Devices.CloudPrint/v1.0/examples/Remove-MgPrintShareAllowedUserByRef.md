### Example 1: Using the Remove-MgPrintShareAllowedUserByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Remove-MgPrintShareAllowedUserByRef -PrinterShareId $printerShareId -UserId $userId
```
This example shows how to use the Remove-MgPrintShareAllowedUserByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
