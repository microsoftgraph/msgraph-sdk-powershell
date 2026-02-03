### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	displayName = "displayName-value"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserMailFolder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

