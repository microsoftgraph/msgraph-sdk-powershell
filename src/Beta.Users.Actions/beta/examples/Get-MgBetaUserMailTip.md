### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	EmailAddresses = @(
	"danas@contoso.com"
"fannyd@contoso.com"
)
MailTipsOptions = "automaticReplies, mailboxFullStatus"
}

# A UPN can also be used as -UserId.
Get-MgBetaUserMailTip -UserId $userId -BodyParameter $params

```
This example shows how to use the Get-MgBetaUserMailTip Cmdlet.

