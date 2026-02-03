### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Executive Division"
	membershipType = "Dynamic"
	membershipRule = "(user.country -eq "United States")"
	membershipRuleProcessingState = "On"
}

Update-MgBetaAdministrativeUnit -AdministrativeUnitId $administrativeUnitId -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdministrativeUnit Cmdlet.

