### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	retentionSettings = @{
		isRecordLocked = $true
	}
}

Update-MgBetaDriveItemRetentionLabel -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDriveItemRetentionLabel Cmdlet.

