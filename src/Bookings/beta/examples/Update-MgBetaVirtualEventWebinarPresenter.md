### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	presenterDetails = @{
		bio = @{
			content = "Lead Product Manager of Contoso Sales department"
			contentType = "text"
		}
		company = "Contoso"
		jobTitle = "Product Manager"
		linkedInProfileWebUrl = "https://linkedin.com/in/DianeDemoss"
		personalSiteWebUrl = "https://DianeDemoss.com"
	}
}

Update-MgBetaVirtualEventWebinarPresenter -VirtualEventWebinarId $virtualEventWebinarId -VirtualEventPresenterId $virtualEventPresenterId -BodyParameter $params

```
This example shows how to use the Update-MgBetaVirtualEventWebinarPresenter Cmdlet.

