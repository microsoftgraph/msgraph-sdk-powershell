### Example 1: Using the Move-MgBetaUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	DestinationId = "destinationId-value"
}
# A UPN can also be used as -UserId.
Move-MgBetaUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the Move-MgBetaUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
