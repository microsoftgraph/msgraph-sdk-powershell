### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Devices.CloudPrint

$params = @{
	event = "jobStarted"
	"definition@odata.bind" = "https://graph.microsoft.com/v1.0/print/taskDefinitions/{taskDefinitionId}"
}

New-MgPrintPrinterTaskTrigger -PrinterId $printerId -BodyParameter $params
```
This example shows how to use the New-MgPrintPrinterTaskTrigger Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

