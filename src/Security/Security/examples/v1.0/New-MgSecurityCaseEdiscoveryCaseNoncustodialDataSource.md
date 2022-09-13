###Example 1
```
Import-Module Microsoft.Graph.Security
$params = @{
	DataSource = @{
		"@odata.type" = "microsoft.graph.security.siteSource"
	}
}
New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
