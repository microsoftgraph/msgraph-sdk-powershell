### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	displayName = "Seattle District Technical Schools"
	description = "Seattle district technical schools administration"
	membershipType = "Dynamic"
	membershipRule = "(user.country -eq "United States")"
	membershipRuleProcessingState = "On"
	visibility = "HiddenMembership"
}

New-MgDirectoryAdministrativeUnit -BodyParameter $params

```
This example shows how to use the New-MgDirectoryAdministrativeUnit Cmdlet.

