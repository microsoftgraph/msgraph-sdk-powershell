### Example 1: Acquire a lock on an unlocked file

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	durationMinutes = 30
}

Lock-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example will acquire a lock on an unlocked file

### Example 2: Refresh an existing lock the caller already holds

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	durationMinutes = 10
}

Lock-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example will refresh an existing lock the caller already holds

