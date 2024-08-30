### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	jobTitle = "Contractor"
}

Update-MgBetaDirectoryPendingExternalUserProfile -PendingExternalUserProfileId $pendingExternalUserProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryPendingExternalUserProfile Cmdlet.

