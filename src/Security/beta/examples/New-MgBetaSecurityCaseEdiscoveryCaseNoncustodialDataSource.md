### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	DataSource = @{
		"@odata.type" = "microsoft.graph.security.siteSource"
	}
}
New-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
