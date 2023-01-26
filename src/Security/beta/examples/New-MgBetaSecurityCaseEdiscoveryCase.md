### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	DisplayName = "CONTOSO LITIGATION-005"
	Description = "Project Bazooka"
	ExternalId = "324516"
}
New-MgBetaSecurityCaseEdiscoveryCase -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
