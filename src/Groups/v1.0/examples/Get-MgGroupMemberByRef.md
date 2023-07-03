### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupMember -GroupId $groupId
```
This example shows how to use the Get-MgGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupMember -GroupId $groupId -CountVariable CountVar -Filter "startswith(displayName, 'a')" -ConsistencyLevel eventual
```
This example shows how to use the Get-MgGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

