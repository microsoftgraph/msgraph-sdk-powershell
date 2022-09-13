###Example 1
```
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "microsoft.graph.fileAttachment"
	Name = "name-value"
	ContentType = "contentType-value"
	IsInline = $false
	ContentLocation = "contentLocation-value"
	ContentBytes = "base64-contentBytes-value"
}
# A UPN can also be used as -UserId.
New-MgUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "#microsoft.graph.fileAttachment"
	Name = "smile"
	ContentBytes = "R0lGODdhEAYEAA7"
}
# A UPN can also be used as -UserId.
New-MgUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
