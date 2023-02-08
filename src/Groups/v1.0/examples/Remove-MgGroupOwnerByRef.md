### Example 1: Using the Remove-MgGroupOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
Remove-MgGroupOwnerByRef -GroupId $groupId -DirectoryObjectId $directoryObjectId
```
This example shows how to use the Remove-MgGroupOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
