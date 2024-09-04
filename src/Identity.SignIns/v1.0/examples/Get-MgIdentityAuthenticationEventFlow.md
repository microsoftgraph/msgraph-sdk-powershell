### Example 1: List all user flows

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityAuthenticationEventFlow

```
This example will list all user flows

### Example 2: List all user flows that include Google as an identity provider

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityAuthenticationEventFlow -Filter "microsoft.graph.externalUsersSelfServiceSignUpEventsFlow/onAuthenticationMethodLoadStart/microsoft.graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp/identityProviders/any(idp:idp/id eq 'Google-OAUTH')" 

```
This example will list all user flows that include google as an identity provider

### Example 3: List all user flows that collect 'city' during attribute collection at account creation

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityAuthenticationEventFlow -Filter "microsoft.graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes/any(attribute:attribute/id eq 'city')" 

```
This example will list all user flows that collect 'city' during attribute collection at account creation

### Example 4: List user flow associated with specific application ID

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityAuthenticationEventFlow -Filter "microsoft.graph.externalUsersSelfServiceSignUpEventsFlow/conditions/applications/includeApplications/any(appId:appId/appId eq '63856651-13d9-4784-9abf-20758d509e19')" 

```
This example will list user flow associated with specific application id

