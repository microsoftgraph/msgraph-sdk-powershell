### Example 1: Create a manual alert with a new incident

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.manualAlert"
	title = "Suspicious login from TOR exit node"
	description = "User account showed login activity from known TOR exit node. Manual investigation revealed potential account compromise."
	category = "InitialAccess"
	severity = "high"
	recommendedActions = "Reset user credentials, enable MFA, review recent user activity"
	mitreTechniques = @(
	"T1078"
)
entityDefinitions = @(
	@{
		entityType = "user"
		entityIdentifier = "userPrincipalName"
		identifierValue = "john.doe@contoso.com"
		role = "impacted"
	}
	@{
		entityType = "ip"
		entityIdentifier = "address"
		identifierValue = "185.220.101.50"
		role = "related"
	}
)
}

New-MgBetaSecurityAlertV2 -BodyParameter $params

```
This example will create a manual alert with a new incident

### Example 2: Create a manual alert linked to an existing incident

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.manualAlert"
	title = "Malicious file detected on device"
	description = "Sandbox analysis revealed malicious behavior in downloaded file."
	category = "Execution"
	severity = "high"
	recommendedActions = "Isolate device, remove file, scan for additional IOCs"
	linkToIncident = 
	entityDefinitions = @(
		@{
			entityType = "file"
			entityIdentifier = "sha256"
			identifierValue = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855"
			role = "related"
		}
		@{
			entityType = "device"
			entityIdentifier = "deviceName"
			identifierValue = "DESKTOP-VICTIM01"
			role = "impacted"
		}
	)
}

New-MgBetaSecurityAlertV2 -BodyParameter $params

```
This example will create a manual alert linked to an existing incident

