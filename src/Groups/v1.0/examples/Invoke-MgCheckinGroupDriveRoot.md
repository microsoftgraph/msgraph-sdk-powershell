### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Files

$params = @{
	Comment = "Updating the latest guidelines"
}

Invoke-MgCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Invoke-MgCheckinGroupDriveRoot Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

