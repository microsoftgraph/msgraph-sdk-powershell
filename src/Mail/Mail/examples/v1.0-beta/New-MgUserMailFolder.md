### Example 1: Using the New-MgBetaUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	DisplayName = "Clutter"
	IsHidden = $true
}
# A UPN can also be used as -UserId.
New-MgBetaUserMailFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
