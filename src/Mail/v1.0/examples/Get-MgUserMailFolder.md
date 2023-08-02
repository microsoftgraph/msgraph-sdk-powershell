### Example 1: Get a mail folder

```powershell

Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId

```
This example will get a mail folder

### Example 2: Get a mail sent items folder

```powershell

Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId

```
This example will get a mail sent items folder

