### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMemberAsGroup -GroupId $groupId -CountVariable CountVar  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgGroupTransitiveMemberAsGroup Cmdlet.

