### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	subject = "Annual review"
	body = @{
		contentType = "HTML"
		content = "You should be proud!"
	}
	toRecipients = @(
		@{
			emailAddress = @{
				address = "rufus@contoso.com"
			}
		}
	)
	extensions = @(
		@{
			"@odata.type" = "microsoft.graph.openTypeExtension"
			extensionName = "Com.Contoso.Referral"
			companyName = "Wingtip Toys"
			expirationDate = "2015-12-30T11:00:00.000Z"
			dealValue = 
		}
	)
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

