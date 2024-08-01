### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	destinationId = "destinationId-value"
}

# A UPN can also be used as -UserId.
Copy-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params

```
This example shows how to use the Copy-MgUserMailFolder Cmdlet.

