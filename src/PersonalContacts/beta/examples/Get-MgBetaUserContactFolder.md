### Example 1: Using the Get-MgBetaUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgBetaUserContactFolder -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Get-MgBetaUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgBetaUserContactFolder -UserId $userId
```
This example shows how to use the Get-MgBetaUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
