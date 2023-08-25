### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemThumbnail -DriveId $driveId -DriveItemId $driveItemId

```
This example shows how to use the Get-MgBetaDriveItemThumbnail Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemThumbnail -DriveId $driveId -DriveItemId $driveItemId -Property "c300x400_crop" 

```
This example shows how to use the Get-MgBetaDriveItemThumbnail Cmdlet.

