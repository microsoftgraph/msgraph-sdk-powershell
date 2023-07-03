### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

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

New-MgBetaSiteList -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

