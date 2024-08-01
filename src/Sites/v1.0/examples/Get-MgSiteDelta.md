### Example 1: Initial request

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteDelta

```
This example will initial request

### Example 2: Last page request

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteDelta -Token "1230919asd190410jlka" 

```
This example will last page request

### Example 3: Delta link request

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteDelta -Token "latest" 

```
This example will delta link request

