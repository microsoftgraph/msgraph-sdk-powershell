### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/identityProviders/Google-OAUTH"
}

New-MgBetaIdentityAuthenticationEventFlowAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderByRef -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityAuthenticationEventFlowAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderByRef Cmdlet.

