### Example 1: Using the Get-MgUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolder -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Get-MgUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolder -UserId $userId
```
This example shows how to use the Get-MgUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
