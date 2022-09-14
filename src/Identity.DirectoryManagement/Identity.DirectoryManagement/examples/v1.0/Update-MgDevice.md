### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
}
Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AccountEnabled = $false
}
Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
