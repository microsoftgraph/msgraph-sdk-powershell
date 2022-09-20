### Example 1: Using the New-MgUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "Clutter"
	IsHidden = $true
}
# A UPN can also be used as -UserId.
New-MgUserMailFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
