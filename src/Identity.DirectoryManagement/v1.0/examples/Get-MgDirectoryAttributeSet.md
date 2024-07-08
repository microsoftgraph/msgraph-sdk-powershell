### Example 1: Get all attribute sets

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryAttributeSet

```
This example will get all attribute sets

### Example 2: Get top attribute sets

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryAttributeSet -Top 10 

```
This example will get top attribute sets

### Example 3: Get attribute sets in order

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryAttributeSet -Sort "id" 

```
This example will get attribute sets in order

