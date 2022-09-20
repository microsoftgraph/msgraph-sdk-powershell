### Example 1: Using the Invoke-MgCheckinDriveItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
$params = @{
	Comment = "Updating the latest guidelines"
}
Invoke-MgCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Invoke-MgCheckinDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
