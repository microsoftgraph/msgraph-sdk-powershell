### Example 1: Using the New-MgUserContactFolderContact Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	ParentFolderId = "parentFolderId-value"
	Birthday = [System.DateTime]::Parse("datetime-value")
	FileAs = "fileAs-value"
	DisplayName = "displayName-value"
	GivenName = "givenName-value"
	Initials = "initials-value"
}
# A UPN can also be used as -UserId.
New-MgUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserContactFolderContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
