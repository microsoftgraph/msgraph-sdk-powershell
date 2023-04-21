### Example 1: List all bundles in a drive

```powershellImport-Module Microsoft.Graph.Files

Get-MgDriveBundle -DriveId $driveId
```
This example shows how to use the Get-MgDriveBundle Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all photo albums in a drive

```powershellImport-Module Microsoft.Graph.Files

Get-MgDriveBundle -DriveId $driveId -Filter "bundle/album ne null"
```
This example shows how to use the Get-MgDriveBundle Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

