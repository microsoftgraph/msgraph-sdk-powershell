### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	emailAddress = @{
		name = "Samantha Booth"
		address = "samanthab@contoso.com"
	}
	isInsideOrganization = $true
	isRemovable = $true
	role = "read"
}

New-MgBetaUserCalendarPermission -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserCalendarPermission Cmdlet.

