### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupMemberOf -GroupId $groupId
```
This example shows how to use the Get-MgGroupMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupMemberOfAsGroup -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'A')" -ConsistencyLevel eventual
```
This example shows how to use the Get-MgGroupMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

