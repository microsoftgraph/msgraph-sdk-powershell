### Example 1: Request without Prefer header

```powershellImport-Module Microsoft.Graph.Security

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

Update-MgSecurityAlert -AlertId $alertId -BodyParameter $params
```
This example shows how to use the Get-MgSecurityAlert Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Request with Prefer header

```powershellImport-Module Microsoft.Graph.Security

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

Update-MgSecurityAlert -AlertId $alertId -BodyParameter $params
```
This example shows how to use the Get-MgSecurityAlert Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

