### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Mail

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
New-MgUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

