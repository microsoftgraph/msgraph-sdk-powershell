### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Restore-MgBetaDirectoryDeletedItem -DirectoryObjectId $directoryObjectId

```
This example shows how to use the Restore-MgBetaDirectoryDeletedItem Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	autoReconcileProxyConflict = $true
}

Restore-MgBetaDirectoryDeletedItem -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example shows how to use the Restore-MgBetaDirectoryDeletedItem Cmdlet.

