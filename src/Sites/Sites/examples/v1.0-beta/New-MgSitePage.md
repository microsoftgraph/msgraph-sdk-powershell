### Example 1: Using the New-MgSitePage Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Name = "Events.aspx"
	Title = "Team Events"
	PublishingState = @{
		Level = "checkedOut"
		VersionId = "0.1"
	}
	WebParts = @(
		@{
			Type = "rte"
			Data = @{
				InnerHTML = "<p>Here are the team's upcoming events:</p>"
			}
		}
		@{
			Type = "d1d91016-032f-456d-98a4-721247c305e8"
			Data = @{
				Title = "Events"
				Description = "Display upcoming events"
				DataVersion = "1.0"
			}
		}
	)
}
New-MgSitePage -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgSitePage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
