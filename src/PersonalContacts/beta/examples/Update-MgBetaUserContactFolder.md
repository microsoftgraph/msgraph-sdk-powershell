### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.PersonalContacts

$params = @{
	parentFolderId = "parentFolderId-value"
	displayName = "displayName-value"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserContactFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

