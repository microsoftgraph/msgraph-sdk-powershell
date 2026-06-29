### Example 1: Set status message with expiry date

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	statusMessage = @{
		message = @{
			content = "Hey I'm currently in a meeting."
			contentType = "text"
		}
		expiryDateTime = @{
			dateTime = "2022-10-18T17:05:33.2079781"
			timeZone = "Pacific Standard Time"
		}
	}
}

Set-MgBetaUserPresenceStatusMessage -UserId $userId -BodyParameter $params

```
This example will set status message with expiry date

### Example 2: Set status message of another user

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	statusMessage = @{
		message = @{
			content = "Hey I am available now"
			contentType = "text"
		}
	}
}

Set-MgBetaUserPresenceStatusMessage -UserId $userId -BodyParameter $params

```
This example will set status message of another user

