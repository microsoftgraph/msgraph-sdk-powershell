### Example 1
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	Event = "jobStarted"
	"Definition@odata.bind" = "https://graph.microsoft.com/v1.0/print/taskDefinitions/{taskDefinitionId}"
}
New-MgPrintPrinterTaskTrigger -PrinterId $printerId -BodyParameter $params
```
