### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Name = "updatedCt"
	DocumentSet = @{
		ShouldPrefixNameToFile = $true
		AllowedContentTypes = @(
			@{
				Id = "0x0101"
				Name = "Document"
			}
		)
		DefaultContents = @(
			@{
				FileName = "a.txt"
				ContentType = @{
					Id = "0x0101"
				}
			}
			@{
				FileName = "b.txt"
				ContentType = @{
					Id = "0x0101"
				}
			}
		)
		SharedColumns = @(
			@{
				Name = "Description"
				Id = "cbb92da4-fd46-4c7d-af6c-3128c2a5576e"
			}
			@{
				Name = "Address"
				Id = "fc2e188e-ba91-48c9-9dd3-16431afddd50"
			}
		)
		WelcomePageColumns = @(
			@{
				Name = "Address"
				Id = "fc2e188e-ba91-48c9-9dd3-16431afddd50"
			}
		)
	}
}
Update-MgSiteContentType -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
