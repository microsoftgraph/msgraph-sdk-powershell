### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMember -GroupId $groupId
```
This example shows how to use the Get-MgGroupTransitiveMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMemberAsGroup -GroupId $groupId -CountVariable CountVar -ConsistencyLevel eventual
```
This example shows how to use the Get-MgGroupTransitiveMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMemberAsUser -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Search '"displayName:tier"' -Property "displayName,id" -ConsistencyLevel eventual
```
This example shows how to use the Get-MgGroupTransitiveMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMemberAsUser -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'a')" -ConsistencyLevel eventual
```
This example shows how to use the Get-MgGroupTransitiveMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

