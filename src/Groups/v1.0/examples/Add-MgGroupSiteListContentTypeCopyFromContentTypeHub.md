### Example 1: Synchronous pull

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	ContentTypeId = "0x0101"
}

Add-MgSiteListContentTypeCopyFromContentTypeHub -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the Add-MgGroupSiteListContentTypeCopyFromContentTypeHub Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Asynchronous pull

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	ContentTypeId = "0x0101"
}

Add-MgSiteListContentTypeCopyFromContentTypeHub -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the Add-MgGroupSiteListContentTypeCopyFromContentTypeHub Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

