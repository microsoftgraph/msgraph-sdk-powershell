### Example 1: Using the Get-MgUserMailTip Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	EmailAddresses = @(
		"danas@contoso.onmicrosoft.com"
		"fannyd@contoso.onmicrosoft.com"
	)
	MailTipsOptions = "automaticReplies, mailboxFullStatus"
}
# A UPN can also be used as -UserId.
Get-MgUserMailTip -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgUserMailTip Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
