### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroupMemberOfAsGroup -GroupId $groupId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'A')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaGroupMemberOfAsGroup Cmdlet.

