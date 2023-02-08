### Example 1: Using the Submit-MgBetaSecurityTiIndicator Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Value = @(
		@{
			ActivityGroupNames = @(
			)
			Confidence = 0
			Description = "This is a canary indicator for demo purpose. Take no action on any observables set in this indicator."
			ExpirationDateTime = [System.DateTime]::Parse("2019-03-01T21:44:03.1668987+00:00")
			ExternalId = "Test--8586509942423126760MS164-0"
			FileHashType = "sha256"
			FileHashValue = "b555c45c5b1b01304217e72118d6ca1b14b7013644a078273cea27bbdc1cf9d6"
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
		@{
			ActivityGroupNames = @(
			)
			Confidence = 0
			Description = "This is a canary indicator for demo purpose. Take no action on any observables set in this indicator."
			ExpirationDateTime = [System.DateTime]::Parse("2019-03-01T21:44:03.1748779+00:00")
			ExternalId = "Test--8586509942423126760MS164-1"
			FileHashType = "sha256"
			FileHashValue = "1796b433950990b28d6a22456c9d2b58ced1bdfcdf5f16f7e39d6b9bdca4213b"
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
	)
}
Submit-MgBetaSecurityTiIndicator -BodyParameter $params
```
This example shows how to use the Submit-MgBetaSecurityTiIndicator Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
