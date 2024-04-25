### Example 1: Request without Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	assignedTo = "String"
	closedDateTime = [System.DateTime]::Parse("String (timestamp)")
	comments = @(
	"String"
)
feedback = "@odata.type: microsoft.graph.alertFeedback"
status = "@odata.type: microsoft.graph.alertStatus"
tags = @(
"String"
)
vendorInformation = @{
provider = "String"
vendor = "String"
}
}

Update-MgBetaSecurityAlert -AlertId $alertId -BodyParameter $params

```
This example will request without prefer header

### Example 2: Request with Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	assignedTo = "String"
	closedDateTime = [System.DateTime]::Parse("String (timestamp)")
	comments = @(
	"String"
)
feedback = "@odata.type: microsoft.graph.alertFeedback"
status = "@odata.type: microsoft.graph.alertStatus"
tags = @(
"String"
)
vendorInformation = @{
provider = "String"
vendor = "String"
}
}

Update-MgBetaSecurityAlert -AlertId $alertId -BodyParameter $params

```
This example will request with prefer header

