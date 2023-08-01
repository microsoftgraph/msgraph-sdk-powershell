### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	dataSource = @{
		"@odata.type" = "microsoft.graph.security.siteSource"
	}
}

New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.

