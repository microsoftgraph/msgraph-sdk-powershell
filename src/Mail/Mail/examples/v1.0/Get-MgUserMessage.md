###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId
```
###Example 2
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -Property "internetMessageHeaders" 
```
###Example 3
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -Property "subject,body,bodyPreview,uniqueBody" 
```
###Example 4
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId
```
###Example 5
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -Property "sender,subject" 
```
