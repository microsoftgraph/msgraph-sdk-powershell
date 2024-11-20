### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	email = "admin@contoso.com"
	includedSources = "mailbox"
}

New-MgSecurityCaseEdiscoveryCaseCustodianUserSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryCustodianId $ediscoveryCustodianId -BodyParameter $params

```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseCustodianUserSource Cmdlet.

