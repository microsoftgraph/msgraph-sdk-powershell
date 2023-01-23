### Example 1: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.emailAuthenticationMethodConfiguration"
	AllowExternalIdToUseEmailOtp = "disabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.fido2AuthenticationMethodConfiguration"
	State = "enabled"
	IsAttestationEnforced = "true"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration"
	State = "enabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.passwordlessMicrosoftAuthenticatorAuthenticationMethodConfiguration"
	State = "enabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.smsAuthenticationMethodConfiguration"
	Id = "Sms"
	State = "enabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration"
	IsUsableOnce = $true
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 7: Using the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration"
	Id = "X509Certificate"
	State = "enabled"
	CertificateUserBindings = @(
	)
	IncludeTargets = @(
	)
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
