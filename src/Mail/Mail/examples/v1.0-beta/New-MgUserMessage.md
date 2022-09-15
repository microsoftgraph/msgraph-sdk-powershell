### Example 1: Using the New-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	Subject = "Did you see last night's game?"
	Importance = "Low"
	Body = @{
		ContentType = "HTML"
		Content = "They were <b>awesome</b>!"
	}
	ToRecipients = @(
		@{
			EmailAddress = @{
				Address = "AdeleV@contoso.onmicrosoft.com"
			}
		}
	)
}
# A UPN can also be used as -UserId.
New-MgUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	Subject = "9/8/2018: concert"
	Body = @{
		ContentType = "HTML"
		Content = "The group represents Washington."
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
			Value = "Washington"
		}
		@{
			Name = "x-custom-header-group-id"
			Value = "WA001"
		}
	)
}
# A UPN can also be used as -UserId.
New-MgUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	Subject = "Party planning"
	ToRecipients = @(
		@{
			EmailAddress = @{
				Name = "Samantha Booth"
				Address = "samanthab@contoso.onmicrosoft.com"
			}
		}
	)
	Mentions = @(
		@{
			Mentioned = @{
				Name = "Dana Swope"
				Address = "danas@contoso.onmicrosoft.com"
			}
		}
	)
}
# A UPN can also be used as -UserId.
New-MgUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	Subject = "Annual review"
	Body = @{
		ContentType = "HTML"
		Content = "You should be proud!"
	}
	ToRecipients = @(
		@{
			EmailAddress = @{
				Address = "rufus@contoso.com"
			}
		}
	)
	Extensions = @(
		@{
			"@odata.type" = "microsoft.graph.openTypeExtension"
			ExtensionName = "Com.Contoso.Referral"
			CompanyName = "Wingtip Toys"
			ExpirationDate = "2015-12-30T11:00:00.000Z"
			DealValue = 
		}
	)
}
# A UPN can also be used as -UserId.
New-MgUserMessage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
