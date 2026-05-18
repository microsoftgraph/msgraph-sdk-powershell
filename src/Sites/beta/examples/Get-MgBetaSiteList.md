### Example 1: Get list metadata by ID

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteList -SiteId $siteId -ListId $listId

```
This example will get list metadata by id

### Example 2: Get list metadata by title

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteList -SiteId $siteId -ListId $listId

```
This example will get list metadata by title

### Example 3: Get list metadata and items with $select and $expand

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteList -SiteId $siteId -ListId $listId -Property "name,lastModifiedDateTime,itemCount" -ExpandProperty "columns(select=name,description),items)" 

```
This example will get list metadata and items with $select and $expand

### Example 4: Get list metadata and items with multiple $expand parameters

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteList -SiteId $siteId -ListId $listId -Property "name,lastModifiedDateTime" -ExpandProperty "columns(select=name,description),items)" 

```
This example will get list metadata and items with multiple $expand parameters

