###Example 1
```
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
