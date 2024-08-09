### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	name = "Retention label for Contracts"
}

Update-MgDriveItemRetentionLabel -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Update-MgDriveItemRetentionLabel Cmdlet.

