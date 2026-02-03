### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	parentReference = @{
		id = "String"
	}
	name = "String"
}

Restore-MgDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Restore-MgDriveItem Cmdlet.

