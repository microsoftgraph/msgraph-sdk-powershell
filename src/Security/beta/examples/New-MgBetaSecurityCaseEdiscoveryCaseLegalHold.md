### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseLegalHold Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Displayname = "My legalHold with sources"
	Description = "Created from Graph API"
	ContentQuery = "Bazooka"
	"UserSources@odata.bind" = @(
		@{
			"@odata.type" = "microsoft.graph.security.userSource"
			Email = "SalesTeam@M365x809305.OnMicrosoft.com"
		}
	)
	"SiteSources@odata.bind" = @(
		@{
			"@odata.type" = "microsoft.graph.security.siteSource"
		}
	)
}
New-MgBetaSecurityCaseEdiscoveryCaseLegalHold -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseLegalHold Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
