### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	action = "alert"
	activityGroupNames = @(
	)
	confidence = 0
	description = "This is a canary indicator for demo purpose. Take no action on any observables set in this indicator."
	expirationDateTime = [System.DateTime]::Parse("2019-03-01T21:43:37.5031462+00:00")
	externalId = "Test--8586509942679764298MS501"
	fileHashType = "sha256"
	fileHashValue = "aa64428647b57bf51524d1756b2ed746e5a3f31b67cf7fe5b5d8a9daf07ca313"
	killChain = @(
	)
	malwareFamilyNames = @(
	)
	severity = 0
	tags = @(
	)
	targetProduct = "Azure Sentinel"
	threatType = "WatchList"
	tlpLevel = "green"
}

New-MgBetaSecurityTiIndicator -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityTiIndicator Cmdlet.

