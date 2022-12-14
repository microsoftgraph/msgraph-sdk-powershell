### Example 1: Using the Update-MgBetaSecurityAlert Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	AssignedTo = "String"
	ClosedDateTime = [System.DateTime]::Parse("String (timestamp)")
	Comments = @(
		"String"
	)
	Feedback = "@odata.type: microsoft.graph.alertFeedback"
	Status = "@odata.type: microsoft.graph.alertStatus"
	Tags = @(
		"String"
	)
	VendorInformation = @{
		Provider = "String"
		Vendor = "String"
	}
}
Update-MgBetaSecurityAlert -AlertId $alertId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityAlert Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaSecurityAlert Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	AssignedTo = "String"
	ClosedDateTime = [System.DateTime]::Parse("String (timestamp)")
	Comments = @(
		"String"
	)
	Feedback = "@odata.type: microsoft.graph.alertFeedback"
	Status = "@odata.type: microsoft.graph.alertStatus"
	Tags = @(
		"String"
	)
	VendorInformation = @{
		Provider = "String"
		Vendor = "String"
	}
}
Update-MgBetaSecurityAlert -AlertId $alertId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityAlert Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
