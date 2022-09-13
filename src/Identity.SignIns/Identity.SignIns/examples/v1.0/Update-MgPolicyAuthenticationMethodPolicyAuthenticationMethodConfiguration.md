###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.emailAuthenticationMethodConfiguration"
	AllowExternalIdToUseEmailOtp = "enabled"
}
Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.fido2AuthenticationMethodConfiguration"
	State = "enabled"
	IsAttestationEnforced = "true"
}
Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration"
	State = "String"
}
Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration"
	IsUsableOnce = $true
}
Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
