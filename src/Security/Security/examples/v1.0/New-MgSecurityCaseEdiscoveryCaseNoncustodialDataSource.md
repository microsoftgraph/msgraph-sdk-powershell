### Example 1: Using the New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DataSource = @{
		"@odata.type" = "microsoft.graph.security.siteSource"
	}
}
New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
