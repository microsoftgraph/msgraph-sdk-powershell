### Example 1: Retrieve policies and their details in PIM for Microsoft Entra roles

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'" 

```
This example will retrieve policies and their details in pim for microsoft entra roles

### Example 2: Retrieve policies and their details in PIM for groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -Filter "scopeId eq '60bba733-f09d-49b7-8445-32369aa066b3' and scopeType eq 'Group'" -ExpandProperty "rules(`$select=id)" 

```
This example will retrieve policies and their details in pim for groups

