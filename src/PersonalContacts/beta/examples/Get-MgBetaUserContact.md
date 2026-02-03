### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.PersonalContacts

# A UPN can also be used as -UserId.
Get-MgBetaUserContact -UserId $userId -Property "displayName,emailAddresses" 

```
This example shows how to use the Get-MgBetaUserContact Cmdlet.

