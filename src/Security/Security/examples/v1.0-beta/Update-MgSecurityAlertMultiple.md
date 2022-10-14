### Example 1: Using the Update-MgSecurityAlertMultiple Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Value = @(
		@{
			AssignedTo = "String"
			ClosedDateTime = [System.DateTime]::Parse("String (timestamp)")
			Comments = @(
				"String"
			)
			Feedback = @{
				"@odata.type" = "microsoft.graph.alertFeedback"
			}
			Id = "String (identifier)"
			Status = @{
				"@odata.type" = "microsoft.graph.alertStatus"
			}
			Tags = @(
				"String"
			)
			VendorInformation = @{
				Provider = "String"
				Vendor = "String"
			}
		}
	)
}
Update-MgSecurityAlertMultiple -BodyParameter $params
```
This example shows how to use the Update-MgSecurityAlertMultiple Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
