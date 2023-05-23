### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	group = @{
		mail = "SOCTeam@M365x809305.onmicrosoft.com"
	}
	includedSources = "mailbox, site"
}

New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

