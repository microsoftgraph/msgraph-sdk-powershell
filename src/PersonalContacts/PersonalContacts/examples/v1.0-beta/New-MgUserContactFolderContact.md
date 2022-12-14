### Example 1: Using the New-MgBetaUserContactFolderContact Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
$params = @{
	ParentFolderId = "parentFolderId-value"
	Birthday = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	FileAs = "fileAs-value"
	DisplayName = "displayName-value"
	GivenName = "givenName-value"
	Initials = "initials-value"
}
# A UPN can also be used as -UserId.
New-MgBetaUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserContactFolderContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
