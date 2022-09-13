###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
}
Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AccountEnabled = $false
}
Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
