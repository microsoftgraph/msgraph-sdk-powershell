### Example 1: Retrieve the approval resources in entitlement management

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser -On $onId 

```
This example will retrieve the approval resources in entitlement management

