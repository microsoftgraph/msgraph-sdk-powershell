### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Remove-MgDirectoryRoleMemberByRef -DirectoryRoleId $directoryRoleId -DirectoryObjectId $directoryObjectId
```
