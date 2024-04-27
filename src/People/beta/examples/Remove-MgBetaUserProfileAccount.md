### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId

```
This example shows how to use the Remove-MgBetaUserProfileAccount Cmdlet.

