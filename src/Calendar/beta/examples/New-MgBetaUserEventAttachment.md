### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "#Microsoft.OutlookServices.ItemAttachment"
	name = "name-value"
	item = @{
		"@odata.type" = "microsoft.graph.message"
	}
}

# A UPN can also be used as -UserId.
New-MgBetaUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserEventAttachment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

