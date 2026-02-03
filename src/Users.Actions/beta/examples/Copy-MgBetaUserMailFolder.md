### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	destinationId = "destinationId-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaUserMailFolder Cmdlet.

