###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```
###Example 2
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId
```
###Example 3
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```
