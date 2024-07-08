### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.PersonalContacts

$params = @{
	parentFolderId = "AQMkADIxYjJiYgEzLTFmNjYALTRjYTMtODA1NC0wZDkxZGNmOTcxNTQALgAAA8RJzXYaLKZPlmn0ge0edZkBADa3qi2IMXRNg6RwQSHe_F8AAAIBDgAAAA=="
	displayName = "Important contacts"
}

# A UPN can also be used as -UserId.
New-MgUserContactFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserContactFolder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

