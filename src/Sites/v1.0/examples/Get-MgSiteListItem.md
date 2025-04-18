### Example 1: Get list items with specific fields

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteListItem -SiteId $siteId -ListId $listId -ExpandProperty "fields(select=Name,Color,Quantity)" 

```
This example will get list items with specific fields

### Example 2: Get filtered list items with specific fields

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteListItem -SiteId $siteId -ListId $listId -ExpandProperty "fields(select=Name,Color,Quantity)" -Filter "fields/Quantity lt 600" 

```
This example will get filtered list items with specific fields

