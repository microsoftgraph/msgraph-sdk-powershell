### Example 1: Get specified version of a file

```powershellImport-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemVersion -DriveId $driveId -DriveItemId $driveItemId -DriveItemVersionId $driveItemVersionId
```
This example shows how to use the Get-MgBetaDriveItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get current version of a file

```powershellImport-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemVersion -DriveId $driveId -DriveItemId $driveItemId -DriveItemVersionId $driveItemVersionId
```
This example shows how to use the Get-MgBetaDriveItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

