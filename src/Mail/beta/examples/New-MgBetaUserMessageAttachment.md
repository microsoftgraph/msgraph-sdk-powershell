### Example 1: Using the New-MgBetaUserMessageAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	"@odata.type" = "#Microsoft.OutlookServices.FileAttachment"
	Name = "name-value"
	ContentType = "contentType-value"
	IsInline = $false
	ContentLocation = "contentLocation-value"
	ContentBytes = "contentBytes-value"
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaUserMessageAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	"@odata.type" = "#microsoft.graph.fileAttachment"
	Name = "smile"
	ContentBytes = "a0b1c76de9f7="
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaUserMessageAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	"@odata.type" = "#microsoft.graph.itemAttachment"
	Name = "Holiday event"
	Item = @{
		"@odata.type" = "microsoft.graph.event"
		Subject = "Discuss gifts for children"
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgBetaUserMessageAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	"@odata.type" = "#microsoft.graph.referenceAttachment"
	Name = "Personal pictures"
	SourceUrl = "https://contoso.com/personal/mario_contoso_net/Documents/Pics"
	ProviderType = "oneDriveConsumer"
	Permission = "Edit"
	IsFolder = "True"
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
