### Example 1: Get a mail folder

```powershell

Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolder -UserId $userId -MailFolderId $mailFolderId

```
This example will get a mail folder

### Example 2: Get a mail search folder

```powershell

Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolder -UserId $userId -MailFolderId $mailFolderId

```
This example will get a mail search folder

