### Example 1: List all partner configurations within a cross-tenant access policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyCrossTenantAccessPolicyPartner

```
This example will list all partner configurations within a cross-tenant access policy

### Example 2: List the user synchronization policy for all partner configurations

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyCrossTenantAccessPolicyPartner -Property "tenantId" -ExpandProperty "identitySynchronization" 

```
This example will list the user synchronization policy for all partner configurations

