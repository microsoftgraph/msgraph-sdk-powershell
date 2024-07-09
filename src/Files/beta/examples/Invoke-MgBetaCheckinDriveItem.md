### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	comment = "Updating the latest guidelines"
}

Invoke-MgBetaCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaCheckinDriveItem Cmdlet.

