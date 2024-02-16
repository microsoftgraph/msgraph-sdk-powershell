### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	displayName = "Books"
	columns = @(
		@{
			name = "Author"
			text = @{
			}
		}
		@{
			name = "PageCount"
			number = @{
			}
		}
	)
	list = @{
		template = "genericList"
	}
}

New-MgSiteList -SiteId $siteId -BodyParameter $params

```
This example shows how to use the New-MgSiteList Cmdlet.

