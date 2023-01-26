### Example 1: Using the New-MgUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	ParentFolderId = "AQMkADIxYjJiYgEzLTFmNjYALTRjYTMtODA1NC0wZDkxZGNmOTcxNTQALgAAA8RJzXYaLKZPlmn0ge0edZkBADa3qi2IMXRNg6RwQSHe_F8AAAIBDgAAAA=="
	DisplayName = "Important contacts"
}
# A UPN can also be used as -UserId.
New-MgUserContactFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
