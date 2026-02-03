### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Users

Get-MgUserMemberOfAsGroup -UserId $userId -Filter "appRoleAssignments/`$count gt 0" -Property "id,displayName" 

```
This example shows how to use the Get-MgUserMemberOfAsGroup Cmdlet.

