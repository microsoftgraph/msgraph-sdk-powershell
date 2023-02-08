### Example 1: Using the Get-MgBetaDirectoryObjectMemberGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DirectoryObjects
$params = @{
	SecurityEnabledOnly = $false
}
Get-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Get-MgBetaDirectoryObjectMemberGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
