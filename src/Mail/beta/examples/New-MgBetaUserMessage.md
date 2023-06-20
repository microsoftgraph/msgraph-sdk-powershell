### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	subject = "Did you see last night's game?"
	importance = "Low"
	body = @{
		contentType = "HTML"
		content = "They were &lt;b&gt;awesome&lt;/b&gt;!"
	}
	toRecipients = @(
		@{
			emailAddress = @{
				address = "AdeleV@contoso.onmicrosoft.com"
			}
		}
	)
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	subject = "9/8/2018: concert"
	body = @{
		contentType = "HTML"
		content = "The group represents Washington."
	}
	toRecipients = @(
		@{
			emailAddress = @{
				address = "AlexW@contoso.OnMicrosoft.com"
			}
		}
	)
	internetMessageHeaders = @(
		@{
			name = "x-custom-header-group-name"
			value = "Washington"
		}
		@{
			name = "x-custom-header-group-id"
			value = "WA001"
		}
	)
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

