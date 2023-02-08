### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	ToRecipients = @(
		@{
			EmailAddress = @{
				Address = "danas@contoso.onmicrosoft.com"
				Name = "Dana Swope"
			}
		}
	)
	Comment = "Dana, hope you can make this meeting."
}

# A UPN can also be used as -UserId.
Invoke-MgBetaForwardUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaForwardGroupEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

