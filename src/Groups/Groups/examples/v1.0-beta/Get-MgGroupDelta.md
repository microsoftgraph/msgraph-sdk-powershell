### Example 1: Using the Get-MgGroupDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
Get-MgGroupDelta
```
This example shows how to use the Get-MgGroupDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgGroupDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
Get-MgGroupDelta -Property "displayName,description,mailNickname" 
```
This example shows how to use the Get-MgGroupDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
