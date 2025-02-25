### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.PersonalContacts

# A UPN can also be used as -UserId.
Get-MgUserContactFolderContactDelta -UserId $userId -ContactFolderId $contactFolderId -Property "displayName" 

```
This example shows how to use the Get-MgUserContactFolderContactDelta Cmdlet.

