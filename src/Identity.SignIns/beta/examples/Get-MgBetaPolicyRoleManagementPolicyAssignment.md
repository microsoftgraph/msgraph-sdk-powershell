### Example 1: Retrieve details of all role management policy assignments in PIM for Microsoft Entra roles

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -Filter "scopeId eq '/' and scopeType eq 'Directory'" 

```
This example will retrieve details of all role management policy assignments in pim for microsoft entra roles

### Example 2: Retrieve details of all role management policy assignments for a Microsoft Entra role and expand the policy and its associated rules

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole' and roleDefinitionId eq '62e90394-69f5-4237-9190-012177145e10'" -ExpandProperty "policy(`$expand=rules)" 

```
This example will retrieve details of all role management policy assignments for a microsoft entra role and expand the policy and its associated rules

### Example 3: Retrieve details of all role management policy assignments for PIM for groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -Filter "scopeId eq '60bba733-f09d-49b7-8445-32369aa066b3' and scopeType eq 'Group'" 

```
This example will retrieve details of all role management policy assignments for pim for groups

### Example 4: Retrieve details of all role management policy assignments for PIM for groups ownership of a group and expand the policy and its associated rules

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -Filter "scopeId eq '60bba733-f09d-49b7-8445-32369aa066b3' and scopeType eq 'Group' and roleDefinitionId eq 'owner'" -ExpandProperty "policy(`$expand=rules)" 

```
This example will retrieve details of all role management policy assignments for pim for groups ownership of a group and expand the policy and its associated rules

