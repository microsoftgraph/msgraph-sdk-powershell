### Example 1: Using the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId
```
This example shows how to use the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaDirectoryCustomSecurityAttributeDefinition -Filter "attributeSet eq 'Engineering' and status eq 'Available' and type eq 'String'" 
```
This example shows how to use the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaDirectoryCustomSecurityAttributeDefinition -Filter "name eq 'Project' and status eq 'Available'" 
```
This example shows how to use the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaDirectoryCustomSecurityAttributeDefinition
```
This example shows how to use the Get-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
