### Example 1: Restore a deleted item

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Restore-MgDirectoryDeletedItem -DirectoryObjectId $directoryObjectId

```
This example will restore a deleted item

### Example 2: Restore a deleted item and remove any conflicting proxy addresses

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	autoReconcileProxyConflict = $true
}

Restore-MgDirectoryDeletedItem -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example will restore a deleted item and remove any conflicting proxy addresses

