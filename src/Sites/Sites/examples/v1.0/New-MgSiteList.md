###Example 1
```
Import-Module Microsoft.Graph.Sites
$params = @{
	DisplayName = "Books"
	Columns = @(
		@{
			Name = "Author"
			Text = @{
			}
		}
		@{
			Name = "PageCount"
			Number = @{
			}
		}
	)
	List = @{
		Template = "genericList"
	}
}
New-MgSiteList -SiteId $siteId -BodyParameter $params
```
