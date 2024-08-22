### Example 1: List role assignments for a specific service principal in Exchange Online provider

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

Get-MgBetaRoleManagementExchangeRoleAssignment -Filter "principalId eq '/ServicePrincipals/5d39cc4d-ba68-4c44-92c7-5056e3a1ce39'" 

```
This example will list role assignments for a specific service principal in exchange online provider

