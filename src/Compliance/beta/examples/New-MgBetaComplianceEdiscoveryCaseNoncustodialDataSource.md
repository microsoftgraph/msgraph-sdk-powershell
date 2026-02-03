### Example 1: Add a noncustodial data source user or group mailbox with an email

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	applyHoldToSource = $true
	dataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.userSource"
		email = "adelev@contoso.com"
	}
}

New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params

```
This example will add a noncustodial data source user or group mailbox with an email

### Example 2: Add a noncustodial data source site with a URL

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	applyHoldToSource = $false
	dataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.siteSource"
		site = @{
			webUrl = "https://contoso.sharepoint.com/sites/SecretSite"
		}
	}
}

New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params

```
This example will add a noncustodial data source site with a url

