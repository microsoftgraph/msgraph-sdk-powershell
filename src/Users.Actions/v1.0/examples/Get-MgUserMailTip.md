### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	EmailAddresses = @(
	"danas@contoso.com"
"fannyd@contoso.com"
)
MailTipsOptions = "automaticReplies, mailboxFullStatus"
}

# A UPN can also be used as -UserId.
Get-MgUserMailTip -UserId $userId -BodyParameter $params

```
This example shows how to use the Get-MgUserMailTip Cmdlet.

