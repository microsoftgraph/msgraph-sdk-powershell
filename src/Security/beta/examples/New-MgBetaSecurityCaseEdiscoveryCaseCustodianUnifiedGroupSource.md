### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	"group@odata.bind" = "https://graph.microsoft.com/v1.0/groups/93f90172-fe05-43ea-83cf-ff785a40d610"
	includedSources = "mailbox"
}

New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

