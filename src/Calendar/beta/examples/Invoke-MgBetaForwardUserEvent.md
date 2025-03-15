### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	ToRecipients = @(
		@{
			EmailAddress = @{
				Address = "danas@contoso.com"
				Name = "Dana Swope"
			}
		}
	)
	Comment = "Dana, hope you can make this meeting."
}

# A UPN can also be used as -UserId.
Invoke-MgBetaForwardUserEvent -UserId $userId -EventId $eventId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaForwardUserEvent Cmdlet.

