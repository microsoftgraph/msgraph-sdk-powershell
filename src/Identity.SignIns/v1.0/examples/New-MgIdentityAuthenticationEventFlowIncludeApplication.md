### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.authenticationConditionApplication"
	appId = "63856651-13d9-4784-9abf-20758d509e19"
}

New-MgIdentityAuthenticationEventFlowIncludeApplication -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example shows how to use the New-MgIdentityAuthenticationEventFlowIncludeApplication Cmdlet.

