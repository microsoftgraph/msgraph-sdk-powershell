### Example 1: Using the New-MgSecurityTiIndicator Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Action = "alert"
	ActivityGroupNames = @(
	)
	Confidence = 0
	Description = "This is a canary indicator for demo purpose. Take no action on any observables set in this indicator."
	ExpirationDateTime = [System.DateTime]::Parse("2019-03-01T21:43:37.5031462+00:00")
	ExternalId = "Test--8586509942679764298MS501"
	FileHashType = "sha256"
	FileHashValue = "aa64428647b57bf51524d1756b2ed746e5a3f31b67cf7fe5b5d8a9daf07ca313"
	KillChain = @(
	)
	MalwareFamilyNames = @(
	)
	Severity = 0
	Tags = @(
	)
	TargetProduct = "Azure Sentinel"
	ThreatType = "WatchList"
	TlpLevel = "green"
}
New-MgSecurityTiIndicator -BodyParameter $params
```
This example shows how to use the New-MgSecurityTiIndicator Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
