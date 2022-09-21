### Example 1: Using the Remove-MgGroupMemberByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
Remove-MgGroupMemberByRef -GroupId $groupId -DirectoryObjectId $directoryObjectId
```
This example shows how to use the Remove-MgGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
