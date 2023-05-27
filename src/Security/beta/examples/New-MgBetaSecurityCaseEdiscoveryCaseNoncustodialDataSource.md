### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	dataSource = @{
		"@odata.type" = "microsoft.graph.security.siteSource"
	}
}

New-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

