### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	comment = "Updating the latest guidelines"
}

Invoke-MgCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Invoke-MgCheckinDriveItem Cmdlet.

