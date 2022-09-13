###Example 1
```
Import-Module Microsoft.Graph.DirectoryObjects
$params = @{
	SecurityEnabledOnly = $true
}
Get-MgDirectoryObjectMemberObject -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
