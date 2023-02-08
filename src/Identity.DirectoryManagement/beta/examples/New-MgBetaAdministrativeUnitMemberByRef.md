### Example 1: Using the New-MgBetaAdministrativeUnitMemberByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/groups/{id}"
}
New-MgBetaAdministrativeUnitMemberByRef -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgBetaAdministrativeUnitMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
