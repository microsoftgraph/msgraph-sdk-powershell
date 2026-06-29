### Example 1: Create a new arkoseFraudProtectionProvider object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.arkoseFraudProtectionProvider"
	displayName = "Arkose Sign-Up Protection"
	publicKey = "A1EE42E0-C88B-47FE-A176-5E9FB8F116FB"
	privateKey = "19BBE628-7DEF-4E28-AB25-BF129C760B7E"
	clientSubDomain = "client-api"
	verifySubDomain = "verify-api"
}

New-MgIdentityRiskPreventionFraudProtectionProvider -BodyParameter $params

```
This example will create a new arkosefraudprotectionprovider object

### Example 2: Create a new humanSecurityFraudProtectionProvider object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.humanSecurityFraudProtectionProvider"
	displayName = "HUMAN Security Sign-Up Protection"
	appId = "XXyy1XXXy"
	serverToken = "xxYYxxXXX1"
}

New-MgIdentityRiskPreventionFraudProtectionProvider -BodyParameter $params

```
This example will create a new humansecurityfraudprotectionprovider object

