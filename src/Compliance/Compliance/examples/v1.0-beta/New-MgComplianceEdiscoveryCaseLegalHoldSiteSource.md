### Example 1: Using the New-MgComplianceEdiscoveryCaseLegalHoldSiteSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Site = @{
		WebUrl = "https://contoso.sharepoint.com/sites/SecretSite"
	}
}
New-MgComplianceEdiscoveryCaseLegalHoldSiteSource -CaseId $caseId -LegalHoldId $legalHoldId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseLegalHoldSiteSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
