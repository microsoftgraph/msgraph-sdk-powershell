### Example 1: Using the New-MgSiteList Cmdlet
```powershell
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
This example shows how to use the New-MgSiteList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
