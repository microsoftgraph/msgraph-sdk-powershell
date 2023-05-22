### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	name = "updatedCt"
	documentSet = @{
		shouldPrefixNameToFile = $true
		allowedContentTypes = @(
			@{
				id = "0x0101"
				name = "Document"
			}
		)
		defaultContents = @(
			@{
				fileName = "a.txt"
				contentType = @{
					id = "0x0101"
				}
			}
			@{
				fileName = "b.txt"
				contentType = @{
					id = "0x0101"
				}
			}
		)
		sharedColumns = @(
			@{
				name = "Description"
				id = "cbb92da4-fd46-4c7d-af6c-3128c2a5576e"
			}
			@{
				name = "Address"
				id = "fc2e188e-ba91-48c9-9dd3-16431afddd50"
			}
		)
		welcomePageColumns = @(
			@{
				name = "Address"
				id = "fc2e188e-ba91-48c9-9dd3-16431afddd50"
			}
		)
	}
}

Update-MgSiteContentType -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the Get-MgSiteContentType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

