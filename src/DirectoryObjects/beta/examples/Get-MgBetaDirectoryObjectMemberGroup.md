### Example 1: Check group memberships for a directory object

```powershell

Import-Module Microsoft.Graph.Beta.DirectoryObjects

$params = @{
	securityEnabledOnly = $false
}

Get-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example will check group memberships for a directory object

