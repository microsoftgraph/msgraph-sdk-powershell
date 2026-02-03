### Example 1: Create an in-tenant presenter

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	identity = @{
		"@odata.type" = "#microsoft.graph.communicationsUserIdentity"
		id = "7b7e1acd-a3e0-4533-8c1d-c1a4ca0b2e2b"
	}
}

New-MgBetaVirtualEventTownhallPresenter -VirtualEventTownhallId $virtualEventTownhallId -BodyParameter $params

```
This example will create an in-tenant presenter

### Example 2: Create an out-of-tenant presenter

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	identity = @{
		"@odata.type" = "#microsoft.graph.communicationsGuestIdentity"
		displayName = "Guest Speaker"
		email = "guest.speaker@fabrikam.com"
	}
}

New-MgBetaVirtualEventTownhallPresenter -VirtualEventTownhallId $virtualEventTownhallId -BodyParameter $params

```
This example will create an out-of-tenant presenter

