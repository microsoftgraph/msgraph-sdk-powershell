### Example 1: List all partner configurations within a cross-tenant access policy

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyCrossTenantAccessPolicyPartner
```
This example shows how to use the New-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List the user synchronization policy for all partner configurations

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyCrossTenantAccessPolicyPartner -Property "tenantId" -ExpandProperty "identitySynchronization"
```
This example shows how to use the New-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

