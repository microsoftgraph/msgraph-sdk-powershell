### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	disableUserAccounts = $true
}

Invoke-MgBetaForceDomainDelete -DomainId $domainId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaForceDomainDelete Cmdlet.

