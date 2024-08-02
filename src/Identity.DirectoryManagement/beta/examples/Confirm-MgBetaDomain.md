### Example 1: Verify a domain

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Confirm-MgBetaDomain -DomainId $domainId

```
This example will verify a domain

### Example 2: External admin takeover of a domain

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	forceTakeover = $true
}

Confirm-MgBetaDomain -DomainId $domainId -BodyParameter $params

```
This example will external admin takeover of a domain

