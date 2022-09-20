### Example 1: Using the New-MgComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	ApplyHoldToSource = $true
	DataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.userSource"
		Email = "adelev@contoso.com"
	}
}
New-MgComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	ApplyHoldToSource = $false
	DataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.siteSource"
	}
}
New-MgComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
