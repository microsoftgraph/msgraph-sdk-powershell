### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	DestinationId = "destinationId-value"
}

# A UPN can also be used as -UserId.
Move-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the Move-MgUserMailFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

