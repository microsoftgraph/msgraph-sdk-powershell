### Example 1: Retrieve a list of virtual event registrations

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId $virtualEventWebinarId

```
This example will retrieve a list of virtual event registrations

### Example 2: Retrieve a virtual event registration by user ID

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId $virtualEventWebinarId -Filter "userId eq 'b7ef013a-c73c-4ec7-8ccb-e56290f45f68'" 

```
This example will retrieve a virtual event registration by user id

### Example 3: Retrieve a virtual event registration by email

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId $virtualEventWebinarId -Filter "email eq 'EmileeMPham@contoso.com'" 

```
This example will retrieve a virtual event registration by email

