### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isDefault = $true
	supportedServices = @(
		"Email"
		"OfficeCommunicationsOnline"
	)
}

Update-MgBetaDomain -DomainId $domainId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDomain Cmdlet.

