### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.DirectoryObjects

$params = @{
	SecurityEnabledOnly = $true
}

Get-MgDirectoryObjectMemberObject -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Get-MgApplicationMemberObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

