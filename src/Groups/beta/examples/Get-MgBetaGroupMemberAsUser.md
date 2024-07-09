### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroupMemberAsUser -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Search '"displayName:Pr"' -Property "displayName,id"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaGroupMemberAsUser Cmdlet.

