### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.DirectoryObjects

$params = @{
	SecurityEnabledOnly = $true
}

Get-MgBetaDirectoryObjectMemberObject -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Get-MgBetaOrganizationMemberObject Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

