### Example 1: Using the New-MgSecurityCaseEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "CONTOSO LITIGATION-005"
	Description = "Project Bazooka"
	ExternalId = "324516"
}
New-MgSecurityCaseEdiscoveryCase -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
