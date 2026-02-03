### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "sales"
	description = "for employees working with sales and outside sales partners"
	isExternallyVisible = $true
}

New-MgBetaEntitlementManagementAccessPackageCatalog -BodyParameter $params

```
This example shows how to use the New-MgBetaEntitlementManagementAccessPackageCatalog Cmdlet.

