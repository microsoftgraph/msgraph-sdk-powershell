### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/identityProviders/Google-OAUTH"
}

New-MgIdentityAuthenticationEventFlowAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderByRef -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example shows how to use the New-MgIdentityAuthenticationEventFlowAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderByRef Cmdlet.

