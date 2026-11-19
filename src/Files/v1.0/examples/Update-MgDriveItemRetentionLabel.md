### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	retentionSettings = @{
		isRecordLocked = $true
	}
}

Update-MgDriveItemRetentionLabel -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Update-MgDriveItemRetentionLabel Cmdlet.

