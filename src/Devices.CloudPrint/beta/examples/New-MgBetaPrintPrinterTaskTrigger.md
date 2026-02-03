### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	event = "jobStarted"
	"definition@odata.bind" = "https://graph.microsoft.com/beta/print/taskDefinitions/3203656e-6069-4e10-8147-d25290b00a3c"
}

New-MgBetaPrintPrinterTaskTrigger -PrinterId $printerId -BodyParameter $params

```
This example shows how to use the New-MgBetaPrintPrinterTaskTrigger Cmdlet.

