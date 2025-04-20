### Example 1: Restore a deleted directory object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Restore-MgBetaDirectoryDeletedItem -DirectoryObjectId $directoryObjectId

```
This example will restore a deleted directory object

### Example 2: Restore a deleted user and remove conflicting proxy addresses

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	autoReconcileProxyConflict = $true
}

Restore-MgBetaDirectoryDeletedItem -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example will restore a deleted user and remove conflicting proxy addresses

### Example 3: Restore a deleted user and assign them a new userPrincipalName

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	newUserPrincipalName = "johndoe@contoso.com"
}

Restore-MgBetaDirectoryDeletedItem -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example will restore a deleted user and assign them a new userprincipalname

