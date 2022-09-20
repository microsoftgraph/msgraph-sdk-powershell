### Example 1: Using the New-MgUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "#microsoft.graph.fileAttachment"
	Name = "menu.txt"
	ContentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk="
}
# A UPN can also be used as -UserId.
New-MgUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "#microsoft.graph.itemAttachment"
	Name = "Holiday event"
	Item = @{
		"@odata.type" = "microsoft.graph.event"
		Subject = "Discuss gifts for children"
	}
}
# A UPN can also be used as -UserId.
New-MgUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "#Microsoft.OutlookServices.ItemAttachment"
	Name = "name-value"
	Item = @{
		"@odata.type" = "microsoft.graph.message"
	}
}
# A UPN can also be used as -UserId.
New-MgUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "#microsoft.graph.referenceAttachment"
	Name = "Personal pictures"
	SourceUrl = "https://contoso.com/personal/mario_contoso_net/Documents/Pics"
	ProviderType = "oneDriveConsumer"
	Permission = "Edit"
	IsFolder = "True"
}
# A UPN can also be used as -UserId.
New-MgUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
