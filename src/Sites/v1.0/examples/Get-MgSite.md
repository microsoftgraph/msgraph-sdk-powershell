### Example 1: List sites using query parameters

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSite -Property "siteCollection,webUrl" -Filter "siteCollection/root ne null" 

```
This example will list sites using query parameters

### Example 2: List all sites

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSite

```
This example will list all sites

