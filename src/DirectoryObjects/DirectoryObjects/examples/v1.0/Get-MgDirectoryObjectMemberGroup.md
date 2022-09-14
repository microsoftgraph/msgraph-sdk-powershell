### Example 1: Using the Get-MgDirectoryObjectMemberGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.DirectoryObjects
$params = @{
	SecurityEnabledOnly = $false
}
Get-MgDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Get-MgDirectoryObjectMemberGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
