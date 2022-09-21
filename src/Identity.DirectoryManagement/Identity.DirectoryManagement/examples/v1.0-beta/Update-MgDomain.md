### Example 1: Using the Update-MgDomain Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	IsDefault = $true
	SupportedServices = @(
		"Email"
		"OfficeCommunicationsOnline"
	)
}
Update-MgDomain -DomainId $domainId -BodyParameter $params
```
This example shows how to use the Update-MgDomain Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
