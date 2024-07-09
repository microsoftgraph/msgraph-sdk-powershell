### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	displayName = "displayName-value"
	isHidden = $true
}

# A UPN can also be used as -UserId.
New-MgBetaUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMailFolderChildFolder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

