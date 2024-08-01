### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	parentReference = @{
		id = "String"
	}
	name = "String"
}

Restore-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Restore-MgBetaDriveItem Cmdlet.

