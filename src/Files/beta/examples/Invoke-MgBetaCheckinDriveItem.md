### Example 1: Using the Invoke-MgBetaCheckinDriveItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Files
$params = @{
	Comment = "Updating the latest guidelines"
}
Invoke-MgBetaCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaCheckinDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
