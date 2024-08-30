### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}

Remove-MgServicePrincipalOwnerDirectoryObjectByRef -ServicePrincipalId $servicePrincipalId -DirectoryObjectId $directoryObjectId -BodyParameter $params

```
This example shows how to use the Remove-MgServicePrincipalOwnerDirectoryObjectByRef Cmdlet.

