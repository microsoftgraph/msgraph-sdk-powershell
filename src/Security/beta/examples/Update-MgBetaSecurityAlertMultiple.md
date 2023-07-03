### Example 1: Using the Update-MgBetaSecurityAlertMultiple Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
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
Update-MgBetaSecurityAlertMultiple -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityAlertMultiple Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
