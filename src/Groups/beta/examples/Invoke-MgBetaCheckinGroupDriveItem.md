### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

$params = @{
	Comment = "Updating the latest guidelines"
}

Invoke-MgBetaCheckinDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaCheckinGroupDriveItem Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

