### Example 1: Create a fido2combinationConfiguration object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.fido2CombinationConfiguration"
	allowedAAGUIDs = @(
	"486c3b50-889c-480a-abc5-c04ef7c873e0"
"c042882f-a621-40c8-94d3-9cde3a826fed"
"ec454c08-4c77-4012-9d48-45f7f0fccdfb"
)
appliesToCombinations = @(
"fido2"
)
}

New-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration -AuthenticationStrengthPolicyId $authenticationStrengthPolicyId -BodyParameter $params

```
This example will create a fido2combinationconfiguration object

### Example 2: Create a x509CertificateCombinationConfiguration object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.x509CertificateCombinationConfiguration"
	allowedIssuerSkis = @(
	"9A4248C6AC8C2931AB2A86537818E92E7B6C97B6"
)
allowedPolicyOIDs = @(
)
appliesToCombinations = @(
"x509CertificateSingleFactor "
)
}

New-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration -AuthenticationStrengthPolicyId $authenticationStrengthPolicyId -BodyParameter $params

```
This example will create a x509certificatecombinationconfiguration object

