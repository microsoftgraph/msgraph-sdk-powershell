### Example 1: Using the Get-MgDirectoryObjectMemberObject Cmdlet
```powershell
Import-Module Microsoft.Graph.DirectoryObjects
$params = @{
	SecurityEnabledOnly = $true
}
Get-MgDirectoryObjectMemberObject -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Get-MgDirectoryObjectMemberObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
