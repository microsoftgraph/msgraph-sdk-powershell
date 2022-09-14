### Example 1
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Message = @{
		Subject = "Meet for lunch?"
		Body = @{
			ContentType = "Text"
			Content = "The new cafeteria is open."
		}
		ToRecipients = @(
			@{
				EmailAddress = @{
					Address = "fannyd@contoso.onmicrosoft.com"
				}
			}
		)
		CcRecipients = @(
			@{
				EmailAddress = @{
					Address = "danas@contoso.onmicrosoft.com"
				}
			}
		)
	}
	SaveToSentItems = "false"
}
# A UPN can also be used as -UserId.
Send-MgUserMail -UserId $userId -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Message = @{
		Subject = "Meet for lunch?"
		Body = @{
			ContentType = "Text"
			Content = "The new cafeteria is open."
		}
		ToRecipients = @(
			@{
				EmailAddress = @{
					Address = "meganb@contoso.onmicrosoft.com"
				}
			}
		)
		Attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.fileAttachment"
				Name = "attachment.txt"
				ContentType = "text/plain"
				ContentBytes = "SGVsbG8gV29ybGQh"
			}
		)
	}
}
# A UPN can also be used as -UserId.
Send-MgUserMail -UserId $userId -BodyParameter $params
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Message = @{
		Subject = "9/9/2018: concert"
		Body = @{
			ContentType = "HTML"
			Content = "The group represents Nevada."
		}
		ToRecipients = @(
			@{
				EmailAddress = @{
					Address = "AlexW@contoso.OnMicrosoft.com"
				}
			}
		)
		InternetMessageHeaders = @(
			@{
				Name = "x-custom-header-group-name"
				Value = "Nevada"
			}
			@{
				Name = "x-custom-header-group-id"
				Value = "NV001"
			}
		)
	}
}
# A UPN can also be used as -UserId.
Send-MgUserMail -UserId $userId -BodyParameter $params
```
