### Example 1: Get specified version of a file

```powershell

Import-Module Microsoft.Graph.Files

Get-MgDriveItemVersion -DriveId $driveId -DriveItemId $driveItemId -DriveItemVersionId $driveItemVersionId

```
This example will get specified version of a file

### Example 2: Get current version of a file

```powershell

Import-Module Microsoft.Graph.Files

Get-MgDriveItemVersion -DriveId $driveId -DriveItemId $driveItemId -DriveItemVersionId $driveItemVersionId

```
This example will get current version of a file

