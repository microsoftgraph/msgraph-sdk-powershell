### Example 1: Using the Add-MgCommunicationCallLargeGalleryView Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "785f4929-92ca-497b-863f-c778c77c9758"
}
Add-MgCommunicationCallLargeGalleryView -CallId $callId -BodyParameter $params
```
This example shows how to use the Add-MgCommunicationCallLargeGalleryView Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
