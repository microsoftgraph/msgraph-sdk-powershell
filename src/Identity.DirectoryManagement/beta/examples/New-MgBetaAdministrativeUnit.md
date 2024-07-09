### Example 1: Create an administrative unit

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Seattle District Technical Schools"
	description = "Seattle district technical schools administration"
	membershipType = "Dynamic"
	membershipRule = "(user.country -eq "United States")"
	membershipRuleProcessingState = "On"
}

New-MgBetaAdministrativeUnit -BodyParameter $params

```
This example will create an administrative unit

### Example 2: Create a restricted management administrative unit

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Executive Division"
	description = "Executive division administration"
	isMemberManagementRestricted = $true
}

New-MgBetaAdministrativeUnit -BodyParameter $params

```
This example will create a restricted management administrative unit

