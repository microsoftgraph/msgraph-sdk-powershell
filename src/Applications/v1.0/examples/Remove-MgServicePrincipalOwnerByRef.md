### Example 1: Using the Remove-MgServicePrincipalOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}
Remove-MgServicePrincipalOwnerByRef -ServicePrincipalId $servicePrincipalId -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Remove-MgServicePrincipalOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
