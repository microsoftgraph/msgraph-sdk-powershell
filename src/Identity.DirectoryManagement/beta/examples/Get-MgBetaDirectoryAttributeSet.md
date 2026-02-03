### Example 1: Get all attribute sets

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryAttributeSet

```
This example will get all attribute sets

### Example 2: Get top attribute sets

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryAttributeSet -Top 10 

```
This example will get top attribute sets

### Example 3: Get attribute sets in order

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryAttributeSet -Sort "id" 

```
This example will get attribute sets in order

