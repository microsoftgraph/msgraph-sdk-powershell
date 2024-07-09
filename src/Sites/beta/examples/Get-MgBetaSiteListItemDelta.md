### Example 1: Initial request

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteListItemDelta -SiteId $siteId -ListId $listId

```
This example will initial request

### Example 2: Last page request

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteListItemDelta -SiteId $siteId -ListId $listId -Token "1230919asd190410jlka" 

```
This example will last page request

### Example 3: Delta link request

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteListItemDelta -SiteId $siteId -ListId $listId -Token "latest" 

```
This example will delta link request

