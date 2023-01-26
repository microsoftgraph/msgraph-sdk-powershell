### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Group = @{
		Mail = "SOCTeam@M365x809305.onmicrosoft.com"
	}
	IncludedSources = "mailbox, site"
}
New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"Group@odata.bind" = "https://graph.microsoft.com/v1.0/groups/93f90172-fe05-43ea-83cf-ff785a40d610"
	IncludedSources = "mailbox"
}
New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"Group@odata.bind" = "https://graph.microsoft.com/v1.0/groups/93f90172-fe05-43ea-83cf-ff785a40d610"
	IncludedSources = "mailbox"
}
New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
