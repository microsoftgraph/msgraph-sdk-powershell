### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Files

$params = @{
	name = "new-file-name.docx"
}

Update-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

