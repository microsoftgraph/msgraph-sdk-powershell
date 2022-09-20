### Example 1: Using the New-MgAdministrativeUnitMemberByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/groups/{id}"
}
New-MgAdministrativeUnitMemberByRef -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgAdministrativeUnitMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
