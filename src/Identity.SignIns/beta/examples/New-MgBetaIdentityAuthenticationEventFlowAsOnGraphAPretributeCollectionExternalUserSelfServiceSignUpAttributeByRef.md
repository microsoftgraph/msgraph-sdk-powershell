### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/identity/userFlowAttributes/city"
}

New-MgBetaIdentityAuthenticationEventFlowAsOnGraphAPretributeCollectionExternalUserSelfServiceSignUpAttributeByRef -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityAuthenticationEventFlowAsOnGraphAPretributeCollectionExternalUserSelfServiceSignUpAttributeByRef Cmdlet.

