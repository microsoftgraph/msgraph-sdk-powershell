### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Group = @{
		Mail = "SecretGroup@contoso.com"
	}
	IncludedSources = "mailbox, site"
}
New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	"Group@odata.bind" = "https://graph.microsoft.com/v1.0/groups/b96f95c5-b1b3-4142-b039-8ac79e7d2c84"
	IncludedSources = "mailbox, site"
}
New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
