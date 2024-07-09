### Example 1: Default properties

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaContactDelta

```
This example will default properties

### Example 2: Selecting three properties

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaContactDelta -Property "displayName,jobTitle,mail" 

```
This example shows selecting three properties

### Example 3: Alternative minimal response behavior

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaContactDelta -Property "displayName,jobTitle,mail" 

```
This example will alternative minimal response behavior

