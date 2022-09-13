###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	DestinationId = "destinationId-value"
}
# A UPN can also be used as -UserId.
Move-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
