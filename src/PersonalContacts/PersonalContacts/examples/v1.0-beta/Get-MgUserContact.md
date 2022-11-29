### Example 1: Using the Get-MgUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContact -UserId $userId -ContactId $contactId
```
This example shows how to use the Get-MgUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContact -UserId $userId -Property "displayName,emailAddresses" 
```
This example shows how to use the Get-MgUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
