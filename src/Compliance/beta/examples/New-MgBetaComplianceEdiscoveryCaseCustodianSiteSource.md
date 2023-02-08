### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Site = @{
		WebUrl = "https://contoso.sharepoint.com/sites/HumanResources"
	}
}
New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
