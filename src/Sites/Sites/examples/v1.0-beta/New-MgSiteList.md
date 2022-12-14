### Example 1: Using the New-MgBetaSiteList Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
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
New-MgBetaSiteList -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
