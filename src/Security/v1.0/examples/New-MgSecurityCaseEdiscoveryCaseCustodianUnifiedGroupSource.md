### Example 1: Create unifiedGroupSource with group SMTP address

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	group = @{
		mail = "SOCTeam@M365x809305.onmicrosoft.com"
	}
	includedSources = "mailbox, site"
}

New-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params

```
This example will create unifiedgroupsource with group smtp address

### Example 2: Create unifiedGroupSource with group@odata.bind

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"group@odata.bind" = "https://graph.microsoft.com/v1.0/groups/93f90172-fe05-43ea-83cf-ff785a40d610"
	includedSources = "mailbox"
}

New-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params

```
This example will create unifiedgroupsource with group@odata.bind

