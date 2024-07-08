### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.departmentTemplate"
	displayName = "Finance"
}

New-MgSecurityLabelDepartment -BodyParameter $params

```
This example shows how to use the New-MgSecurityLabelDepartment Cmdlet.

