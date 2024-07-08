### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	currentPassword = "xWwvJ]6NMw+bWH-d"
	newPassword = "0eM85N54wFxWwvJ]"
}

# A UPN can also be used as -UserId.
Update-MgUserPassword -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgUserPassword Cmdlet.

