###Example 1
```
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
