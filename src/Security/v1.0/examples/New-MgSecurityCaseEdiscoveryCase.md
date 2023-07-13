### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Security

$params = @{
	displayName = "CONTOSO LITIGATION-005"
	description = "Project Bazooka"
	externalId = "324516"
}

New-MgSecurityCaseEdiscoveryCase -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

