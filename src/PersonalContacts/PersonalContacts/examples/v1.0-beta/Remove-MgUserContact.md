### Example 1: Using the Remove-MgBetaUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Remove-MgBetaUserContact -UserId $userId -ContactId $contactId
```
This example shows how to use the Remove-MgBetaUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
