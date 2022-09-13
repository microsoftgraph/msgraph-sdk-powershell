###Example 1
```
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageDelta -UserId $userId -MailFolderId $mailFolderId
```
