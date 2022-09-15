### Example 1: Using the New-MgComplianceEdiscoveryCaseCustodianSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Site = @{
		WebUrl = "https://contoso.sharepoint.com/sites/HumanResources"
	}
}
New-MgComplianceEdiscoveryCaseCustodianSiteSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseCustodianSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
