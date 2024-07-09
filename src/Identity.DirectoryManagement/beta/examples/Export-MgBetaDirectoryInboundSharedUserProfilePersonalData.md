### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	storageLocation = "MyStorageAccount"
}

Export-MgBetaDirectoryInboundSharedUserProfilePersonalData -InboundSharedUserProfileUserId $inboundSharedUserProfileUserId -BodyParameter $params

```
This example shows how to use the Export-MgBetaDirectoryInboundSharedUserProfilePersonalData Cmdlet.

