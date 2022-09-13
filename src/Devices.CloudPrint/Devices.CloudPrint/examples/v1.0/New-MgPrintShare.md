###Example 1
```
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "ShareName"
	AllowAllUsers = $false
	"Printer@odata.bind" = "https://graph.microsoft.com/v1.0/print/printers/{printerId}"
}
New-MgPrintShare -BodyParameter $params
```
