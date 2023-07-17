### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	event = "jobStarted"
	"definition@odata.bind" = "https://graph.microsoft.com/v1.0/print/taskDefinitions/{taskDefinitionId}"
}

New-MgBetaPrintPrinterTaskTrigger -PrinterId $printerId -BodyParameter $params
```
This example shows how to use the New-MgBetaPrintPrinterTaskTrigger Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

