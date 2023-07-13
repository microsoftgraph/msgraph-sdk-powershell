### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "Quarterly Financials search"
	ContentQuery = "subject:'Quarterly Financials'"
	"CustodianSources@odata.bind" = @(
		"https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/custodians/2192ca408ea2410eba3bec8ae873be6b/userSources/46384443-4137-3032-3437-363939433735"
	)
}
New-MgBetaComplianceEdiscoveryCaseSourceCollection -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
