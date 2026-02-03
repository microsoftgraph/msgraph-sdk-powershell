### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Functions

# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageDelta -UserId $userId -MailFolderId $mailFolderId

```
This example shows how to use the Get-MgUserMailFolderMessageDelta Cmdlet.

