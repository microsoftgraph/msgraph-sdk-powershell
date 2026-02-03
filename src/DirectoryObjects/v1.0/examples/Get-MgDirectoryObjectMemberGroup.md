### Example 1: Check group memberships for a directory object

```powershell

Import-Module Microsoft.Graph.DirectoryObjects

$params = @{
	securityEnabledOnly = $false
}

Get-MgDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example will check group memberships for a directory object

