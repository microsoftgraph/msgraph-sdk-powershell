### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	email = "admin@contoso.com"
	includedSources = "mailbox"
}

New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryHoldPolicyId $ediscoveryHoldPolicyId -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource Cmdlet.

