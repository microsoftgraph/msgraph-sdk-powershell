### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	ApplyHoldToSource = $true
	DataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.userSource"
		Email = "adelev@contoso.com"
	}
}
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	ApplyHoldToSource = $false
	DataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.siteSource"
	}
}
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
