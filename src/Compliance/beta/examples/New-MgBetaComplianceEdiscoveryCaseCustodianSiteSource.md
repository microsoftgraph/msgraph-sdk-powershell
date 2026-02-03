### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	site = @{
		webUrl = "https://contoso.sharepoint.com/sites/HumanResources"
	}
}

New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource Cmdlet.

