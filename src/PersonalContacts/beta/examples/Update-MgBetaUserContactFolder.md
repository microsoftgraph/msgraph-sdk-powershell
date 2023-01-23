### Example 1: Using the Update-MgBetaUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
$params = @{
	ParentFolderId = "parentFolderId-value"
	DisplayName = "displayName-value"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserContactFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
