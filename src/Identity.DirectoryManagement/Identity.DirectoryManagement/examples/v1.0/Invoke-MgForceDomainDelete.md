###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	DisableUserAccounts = $true
}
Invoke-MgForceDomainDelete -DomainId $domainId -BodyParameter $params
```
