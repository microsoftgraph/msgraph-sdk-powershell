### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

Get-MgGroupMemberOfAsGroup -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'A')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgGroupMemberOfAsGroup Cmdlet.

