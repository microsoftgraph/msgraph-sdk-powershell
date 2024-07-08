### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	message = @{
		subject = "Meet for lunch?"
		body = @{
			contentType = "Text"
			content = "The new cafeteria is open."
		}
		toRecipients = @(
			@{
				emailAddress = @{
					address = "samanthab@contoso.com"
				}
			}
		)
		ccRecipients = @(
			@{
				emailAddress = @{
					address = "danas@contoso.com"
				}
			}
		)
	}
	saveToSentItems = "false"
}

# A UPN can also be used as -UserId.
Send-MgBetaUserMail -UserId $userId -BodyParameter $params

```
This example shows how to use the Send-MgBetaUserMail Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	message = @{
		subject = "Project kickoff"
		toRecipients = @(
			@{
				emailAddress = @{
					name = "Samantha Booth"
					address = "samanthab@contoso.com"
				}
			}
		)
		mentions = @(
			@{
				mentioned = @{
					name = "Dana Swope"
					address = "danas@contoso.com"
				}
			}
		)
	}
}

# A UPN can also be used as -UserId.
Send-MgBetaUserMail -UserId $userId -BodyParameter $params

```
This example shows how to use the Send-MgBetaUserMail Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	message = @{
		subject = "9/9/2018: concert"
		body = @{
			contentType = "HTML"
			content = "The group represents Nevada."
		}
		toRecipients = @(
			@{
				emailAddress = @{
					address = "AlexW@contoso.com"
				}
			}
		)
		internetMessageHeaders = @(
			@{
				name = "x-custom-header-group-name"
				value = "Nevada"
			}
			@{
				name = "x-custom-header-group-id"
				value = "NV001"
			}
		)
	}
}

# A UPN can also be used as -UserId.
Send-MgBetaUserMail -UserId $userId -BodyParameter $params

```
This example shows how to use the Send-MgBetaUserMail Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	message = @{
		subject = "Meet for lunch?"
		body = @{
			contentType = "Text"
			content = "The new cafeteria is open."
		}
		toRecipients = @(
			@{
				emailAddress = @{
					address = "meganb@contoso.com"
				}
			}
		)
		attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.fileAttachment"
				name = "attachment.txt"
				contentType = "text/plain"
				contentBytes = "SGVsbG8gV29ybGQh"
			}
		)
	}
}

# A UPN can also be used as -UserId.
Send-MgBetaUserMail -UserId $userId -BodyParameter $params

```
This example shows how to use the Send-MgBetaUserMail Cmdlet.

