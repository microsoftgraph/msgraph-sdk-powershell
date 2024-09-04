### Example 1: Create a new group

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.group"
	description = "Self help community for golf"
	displayName = "Golf Assist"
	groupTypes = @(
	"Unified"
)
mailEnabled = $true
mailNickname = "golfassist"
securityEnabled = $false
}

New-MgBetaAdministrativeUnitMember -AdministrativeUnitId $administrativeUnitId -BodyParameter $params

```
This example will create a new group

