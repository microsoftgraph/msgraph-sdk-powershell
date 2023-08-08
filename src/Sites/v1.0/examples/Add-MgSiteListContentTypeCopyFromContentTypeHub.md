### Example 1: Synchronous pull

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	contentTypeId = "0x0101"
}

Add-MgSiteListContentTypeCopyFromContentTypeHub -SiteId $siteId -ListId $listId -BodyParameter $params

```
This example synchronous pull

### Example 2: Asynchronous pull

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	contentTypeId = "0x0101"
}

Add-MgSiteListContentTypeCopyFromContentTypeHub -SiteId $siteId -ListId $listId -BodyParameter $params

```
This example asynchronous pull

