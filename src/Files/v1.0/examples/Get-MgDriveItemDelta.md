### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

Get-MgDriveItemDelta -DriveId $driveId -DriveItemId $driveItemId

```
This example shows how to use the Get-MgDriveItemDelta Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

Get-MgDriveItemDelta -DriveId $driveId -DriveItemId $driveItemId -Token "latest" 

```
This example shows how to use the Get-MgDriveItemDelta Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

Get-MgDriveItemDelta -DriveId $driveId -DriveItemId $driveItemId -Token "2021-09-29T20:00:00Z" 

```
This example shows how to use the Get-MgDriveItemDelta Cmdlet.

