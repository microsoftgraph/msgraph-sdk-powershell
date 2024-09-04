### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	jobTitle = "Contractor"
}

Update-MgBetaDirectoryExternalUserProfile -ExternalUserProfileId $externalUserProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryExternalUserProfile Cmdlet.

