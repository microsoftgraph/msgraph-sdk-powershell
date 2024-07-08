### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMemberAsUser -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Search '"displayName:tier"' -Property "displayName,id"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgGroupTransitiveMemberAsUser Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

Get-MgGroupTransitiveMemberAsUser -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'a')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgGroupTransitiveMemberAsUser Cmdlet.

