### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

$params = @{
	reason = "String"
}

Invoke-MgAbortPrintPrinterJob -PrinterId $printerId -PrintJobId $printJobId -BodyParameter $params

```
This example shows how to use the Invoke-MgAbortPrintPrinterJob Cmdlet.

