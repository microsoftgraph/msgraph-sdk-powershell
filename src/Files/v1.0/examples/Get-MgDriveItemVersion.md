### Example 1: Get specified version of a file

```powershellImport-Module Microsoft.Graph.Files

Get-MgDriveItemVersion -DriveId $driveId -DriveItemId $driveItemId -DriveItemVersionId $driveItemVersionId
```
This example shows how to use the Get-MgDriveItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get current version of a file

```powershellImport-Module Microsoft.Graph.Files

Get-MgDriveItemVersion -DriveId $driveId -DriveItemId $driveItemId -DriveItemVersionId $driveItemVersionId
```
This example shows how to use the Get-MgDriveItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

