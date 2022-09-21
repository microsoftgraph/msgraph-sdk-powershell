### Example 1: Using the Remove-MgPrintPrinterShareAllowedUserByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
Remove-MgPrintPrinterShareAllowedUserByRef -PrinterShareId $printerShareId -UserId $userId
```
This example shows how to use the Remove-MgPrintPrinterShareAllowedUserByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
