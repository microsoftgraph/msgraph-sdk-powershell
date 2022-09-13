###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId
```
###Example 2
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId -AttachmentId $attachmentId -ExpandProperty "microsoft.graph.itemattachment/item" 
```
###Example 3
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId -AttachmentId $attachmentId -ExpandProperty "microsoft.graph.itemattachment/item" 
```
###Example 4
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId -AttachmentId $attachmentId
```
###Example 5
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId -AttachmentId $attachmentId
```
###Example 6
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId -AttachmentId $attachmentId
```
###Example 7
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageAttachment -UserId $userId -MessageId $messageId
```
