### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Example"
	requirementsSatisfied = "mfa"
	allowedCombinations = @(
	"fido2"
)
"combinationConfigurations@odata.context" = "https://graph.microsoft.com/beta/$metadata#policies/authenticationStrengthPolicies('5790842a-5bab-44c2-9cf1-b38d675b70ea')/combinationConfigurations"
combinationConfigurations = @(
	@{
		"@odata.type" = "#microsoft.graph.fido2CombinationConfiguration"
		id = "42235320-c8db-4d8c-9344-8f1ce87f734b"
		appliesToCombinations = @(
		"fido2"
	)
	allowedAAGUIDs = @(
	"de1e552d-db1d-4423-a619-566b625cdc84"
"90a3ccdf-635c-4729-a248-9b709135078f"
)
}
)
}

New-MgBetaPolicyAuthenticationStrengthPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyAuthenticationStrengthPolicy Cmdlet.

