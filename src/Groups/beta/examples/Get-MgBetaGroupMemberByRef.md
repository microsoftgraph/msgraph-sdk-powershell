### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroupMember -GroupId $groupId
```
This example shows how to use the Get-MgBetaGroupMemberByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroupMember -GroupId $groupId -CountVariable CountVar -Filter "startswith(displayName, 'a')" -ConsistencyLevel eventual
```
This example shows how to use the Get-MgBetaGroupMemberByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

