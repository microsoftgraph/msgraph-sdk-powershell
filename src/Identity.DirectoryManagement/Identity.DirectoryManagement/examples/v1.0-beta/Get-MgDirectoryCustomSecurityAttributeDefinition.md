### Example 1: Using the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId
```
This example shows how to use the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryCustomSecurityAttributeDefinition -Filter "attributeSet eq 'Engineering' and status eq 'Available' and type eq 'String'" 
```
This example shows how to use the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryCustomSecurityAttributeDefinition -Filter "name eq 'Project' and status eq 'Available'" 
```
This example shows how to use the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryCustomSecurityAttributeDefinition
```
This example shows how to use the Get-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
