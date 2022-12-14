### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Site = @{
		WebUrl = "https://contoso.sharepoint.com/sites/SecretSite"
	}
}
New-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
