### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Files

Get-MgDriveItemThumbnail -DriveId $driveId -DriveItemId $driveItemId
```
This example shows how to use the Get-MgDriveItemThumbnail Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Files

Get-MgDriveItemThumbnail -DriveId $driveId -DriveItemId $driveItemId -Property "c300x400_crop"
```
This example shows how to use the Get-MgDriveItemThumbnail Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

