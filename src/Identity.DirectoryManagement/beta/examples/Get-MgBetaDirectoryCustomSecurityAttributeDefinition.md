### Example 1: Get all custom security attributes

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryCustomSecurityAttributeDefinition

```
This example will get all custom security attributes

### Example 2: Filter custom security attributes based on name

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryCustomSecurityAttributeDefinition -Filter "name eq 'Project' and status eq 'Available'" 

```
This example will filter custom security attributes based on name

### Example 3: Filter custom security attributes based on attribute set

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryCustomSecurityAttributeDefinition -Filter "attributeSet eq 'Engineering' and status eq 'Available' and type eq 'String'" 

```
This example will filter custom security attributes based on attribute set

