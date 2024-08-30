### Example 1: Create an in-tenant presenter on a **virtualEventWebinar**

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	identity = @{
		"@odata.type" = "#microsoft.graph.communicationsUserIdentity"
		id = "7b7e1acd-a3e0-4533-8c1d-c1a4ca0b2e2b"
	}
}

New-MgVirtualEventWebinarPresenter -VirtualEventWebinarId $virtualEventWebinarId -BodyParameter $params

```
This example will create an in-tenant presenter on a **virtualeventwebinar**

### Example 2: Create an out-of-tenant presenter on a **virtualEventWebinar**

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	identity = @{
		"@odata.type" = "#microsoft.graph.communicationsGuestIdentity"
		displayName = "Guest Speaker"
		email = "guest.speaker@fabrikam.com"
	}
}

New-MgVirtualEventWebinarPresenter -VirtualEventWebinarId $virtualEventWebinarId -BodyParameter $params

```
This example will create an out-of-tenant presenter on a **virtualeventwebinar**

