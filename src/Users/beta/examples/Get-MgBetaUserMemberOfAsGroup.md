### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users

Get-MgBetaUserMemberOfAsGroup -UserId $userId -Filter "appRoleAssignments/`$count gt 0" -Property "id,displayName" 

```
This example shows how to use the Get-MgBetaUserMemberOfAsGroup Cmdlet.

