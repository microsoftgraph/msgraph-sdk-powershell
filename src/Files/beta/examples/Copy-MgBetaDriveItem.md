### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	parentReference = @{
		driveId = "6F7D00BF-FC4D-4E62-9769-6AEA81F3A21B"
		id = "DCD0D3AD-8989-4F23-A5A2-2C086050513F"
	}
	name = "contoso plan (copy).txt"
}

Copy-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaDriveItem Cmdlet.

