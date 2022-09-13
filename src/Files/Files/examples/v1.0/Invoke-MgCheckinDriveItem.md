###Example 1
```
Import-Module Microsoft.Graph.Files
$params = @{
	Comment = "Updating the latest guidelines"
}
Invoke-MgCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
