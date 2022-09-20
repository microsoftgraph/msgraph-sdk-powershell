### Example 1: Using the New-MgAdministrativeUnit Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	DisplayName = "Seattle District Technical Schools"
	Description = "Seattle district technical schools administration"
	MembershipType = "Dynamic"
	MembershipRule = "(user.country -eq "United States")"
	MembershipRuleProcessingState = "On"
}
New-MgAdministrativeUnit -BodyParameter $params
```
This example shows how to use the New-MgAdministrativeUnit Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
