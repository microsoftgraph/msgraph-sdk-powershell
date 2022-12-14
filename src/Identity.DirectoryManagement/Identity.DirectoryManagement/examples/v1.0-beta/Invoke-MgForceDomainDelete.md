### Example 1: Using the Invoke-MgBetaForceDomainDelete Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	DisableUserAccounts = $true
}
Invoke-MgBetaForceDomainDelete -DomainId $domainId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaForceDomainDelete Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
