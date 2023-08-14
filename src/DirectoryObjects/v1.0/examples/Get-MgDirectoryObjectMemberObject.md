### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DirectoryObjects

$params = @{
	securityEnabledOnly = $true
}

Get-MgDirectoryObjectMemberObject -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example shows how to use the Get-MgDirectoryObjectMemberObject Cmdlet.

