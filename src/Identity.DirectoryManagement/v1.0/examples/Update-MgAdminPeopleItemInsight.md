### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	disabledForGroup = "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}

Update-MgAdminPeopleItemInsight -BodyParameter $params

```
This example shows how to use the Update-MgAdminPeopleItemInsight Cmdlet.

