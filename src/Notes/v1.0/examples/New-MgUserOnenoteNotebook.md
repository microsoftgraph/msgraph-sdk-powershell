### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Notes

$params = @{
	displayName = "My Private notebook"
}

# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebook -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgUserOnenoteNotebook Cmdlet.

