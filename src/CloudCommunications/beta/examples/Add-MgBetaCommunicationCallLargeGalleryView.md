### Example 1: Using the Add-MgBetaCommunicationCallLargeGalleryView Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	ClientContext = "785f4929-92ca-497b-863f-c778c77c9758"
}
Add-MgBetaCommunicationCallLargeGalleryView -CallId $callId -BodyParameter $params
```
This example shows how to use the Add-MgBetaCommunicationCallLargeGalleryView Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
