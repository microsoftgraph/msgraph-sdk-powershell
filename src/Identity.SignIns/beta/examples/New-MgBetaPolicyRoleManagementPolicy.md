### Example 1: Retrieve the role management policies that apply to Azure AD roles

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'"
```
This example shows how to use the New-MgBetaBetaPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve the role management policies that apply to the directory and expand the associated rules

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'Directory'" -ExpandProperty "rules"
```
This example shows how to use the New-MgBetaBetaPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

