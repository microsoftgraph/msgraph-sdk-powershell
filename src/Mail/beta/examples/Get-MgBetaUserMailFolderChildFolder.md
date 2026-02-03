### Example 1: List mail folders

```powershell

Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId

```
This example will list mail folders

### Example 2: List mail search folders

```powershell

Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId

```
This example will list mail search folders

### Example 3: Include hidden child folders under a specified mail folder

```powershell

Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId -Includehiddenfolders true 

```
This example will include hidden child folders under a specified mail folder

