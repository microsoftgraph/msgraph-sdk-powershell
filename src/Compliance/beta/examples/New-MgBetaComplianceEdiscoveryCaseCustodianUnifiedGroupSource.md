### Example 1: Create unifiedGroupSource with group SMTP address

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	group = @{
		mail = "SecretGroup@contoso.com"
	}
	includedSources = "mailbox, site"
}

New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params

```
This example will create unifiedgroupsource with group smtp address

### Example 2: Create unifiedGroupSource with group@odata.bind

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	"group@odata.bind" = "https://graph.microsoft.com/v1.0/groups/b96f95c5-b1b3-4142-b039-8ac79e7d2c84"
	includedSources = "mailbox, site"
}

New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource -CaseId $caseId -CustodianId $custodianId -BodyParameter $params

```
This example will create unifiedgroupsource with group@odata.bind

