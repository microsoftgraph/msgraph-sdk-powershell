### Example 1: Using the Remove-MgBetaServicePrincipalOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}
Remove-MgBetaServicePrincipalOwnerByRef -ServicePrincipalId $servicePrincipalId -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaServicePrincipalOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
