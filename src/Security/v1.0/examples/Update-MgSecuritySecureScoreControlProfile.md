### Example 1: Request without Prefer header

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	assignedTo = ""
	comment = "control is reviewed"
	state = "Reviewed"
	vendorInformation = @{
		provider = "SecureScore"
		providerVersion = $null
		subProvider = $null
		vendor = "Microsoft"
	}
}

Update-MgSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params

```
This example will request without prefer header

### Example 2: Request with Prefer header

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	assignedTo = ""
	comment = "control is reviewed"
	state = "Reviewed"
	vendorInformation = @{
		provider = "SecureScore"
		providerVersion = $null
		subProvider = $null
		vendor = "Microsoft"
	}
}

Update-MgSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params

```
This example will request with prefer header

