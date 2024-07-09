### Example 1: Use $searchand OData cast to get user membership in groups with display names that contain the letters 'Pr' including a count of returned objects

```powershell

Import-Module Microsoft.Graph.Groups

Get-MgGroupMemberAsUser -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Search '"displayName:Pr"' -Property "displayName,id"  -ConsistencyLevel eventual 


```
This example will use $searchand odata cast to get user membership in groups with display names that contain the letters 'pr' including a count of returned objects

