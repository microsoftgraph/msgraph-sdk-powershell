### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	clientContext = "785f4929-92ca-497b-863f-c778c77c9758"
}

Add-MgBetaCommunicationCallLargeGalleryView -CallId $callId -BodyParameter $params

```
This example shows how to use the Add-MgBetaCommunicationCallLargeGalleryView Cmdlet.

