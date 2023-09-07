### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserChat -UserId $userId

```
This example shows how to use the Get-MgBetaUserChat Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserChat -UserId $userId -ExpandProperty "members" -Filter "members/any(o: o/displayname eq 'Peter Parker')" 

```
This example shows how to use the Get-MgBetaUserChat Cmdlet.

