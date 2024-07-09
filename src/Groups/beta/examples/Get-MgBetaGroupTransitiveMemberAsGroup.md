### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroupTransitiveMemberAsGroup -GroupId $groupId -CountVariable CountVar  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaGroupTransitiveMemberAsGroup Cmdlet.

