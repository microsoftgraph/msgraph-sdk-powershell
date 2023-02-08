### Example 1: Using the Get-MgBetaUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgBetaUserContact -UserId $userId -ContactId $contactId
```
This example shows how to use the Get-MgBetaUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgBetaUserContact -UserId $userId -Property "displayName,emailAddresses" 
```
This example shows how to use the Get-MgBetaUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
