### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users

$params = @{
	color = "preset15"
}

# A UPN can also be used as -UserId.
Update-MgUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId -BodyParameter $params
```
This example shows how to use the Remove-MgUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

