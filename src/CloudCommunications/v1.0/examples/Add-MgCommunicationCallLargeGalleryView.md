### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	clientContext = "785f4929-92ca-497b-863f-c778c77c9758"
}

Add-MgCommunicationCallLargeGalleryView -CallId $callId -BodyParameter $params

```
This example shows how to use the Add-MgCommunicationCallLargeGalleryView Cmdlet.

