### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement -AccessPackageId $accessPackageId

```
This example shows how to use the Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	subject = @{
		objectId = "5acd375c-8acb-45de-a958-fa0dd89259ad"
	}
}

Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement -AccessPackageId $accessPackageId -BodyParameter $params

```
This example shows how to use the Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement Cmdlet.

