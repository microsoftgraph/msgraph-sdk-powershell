###Example 1
```
Import-Module Microsoft.Graph.DirectoryObjects
$params = @{
	SecurityEnabledOnly = $false
}
Get-MgDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
