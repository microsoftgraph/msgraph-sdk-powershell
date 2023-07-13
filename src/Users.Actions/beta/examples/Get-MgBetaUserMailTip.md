### Example 1: Using the Get-MgBetaUserMailTip Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	EmailAddresses = @(
		"danas@contoso.onmicrosoft.com"
		"fannyd@contoso.onmicrosoft.com"
	)
	MailTipsOptions = "automaticReplies, mailboxFullStatus"
}
# A UPN can also be used as -UserId.
Get-MgBetaUserMailTip -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgBetaUserMailTip Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
