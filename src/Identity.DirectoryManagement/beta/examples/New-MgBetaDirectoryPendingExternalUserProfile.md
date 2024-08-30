### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	phoneNumber = "+15555555555"
	displayName = "Bob Henry"
}

New-MgBetaDirectoryPendingExternalUserProfile -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryPendingExternalUserProfile Cmdlet.

