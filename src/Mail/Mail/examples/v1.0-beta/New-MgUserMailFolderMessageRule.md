### Example 1: Using the New-MgUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "From partner"
	Sequence = 2
	IsEnabled = $true
	Conditions = @{
		SenderContains = @(
			"adele"
		)
	}
	Actions = @{
		ForwardTo = @(
			@{
				EmailAddress = @{
					Name = "Alex Wilbur"
					Address = "AlexW@contoso.onmicrosoft.com"
				}
			}
		)
		StopProcessingRules = $true
	}
}
# A UPN can also be used as -UserId.
New-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
