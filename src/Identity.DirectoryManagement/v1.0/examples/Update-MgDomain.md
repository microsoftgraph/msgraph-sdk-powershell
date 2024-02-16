### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	isDefault = $true
	supportedServices = @(
		"Email"
		"OfficeCommunicationsOnline"
	)
}

Update-MgDomain -DomainId $domainId -BodyParameter $params

```
This example shows how to use the Update-MgDomain Cmdlet.

