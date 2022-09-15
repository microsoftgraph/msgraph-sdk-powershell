### Example 1: Using the Invoke-MgForceDomainDelete Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	DisableUserAccounts = $true
}
Invoke-MgForceDomainDelete -DomainId $domainId -BodyParameter $params
```
This example shows how to use the Invoke-MgForceDomainDelete Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
