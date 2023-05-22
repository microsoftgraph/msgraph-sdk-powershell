### Example 1: Request without Prefer header

```powershellImport-Module Microsoft.Graph.Security

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
This example shows how to use the Get-MgSecuritySecureScoreControlProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Request with Prefer header

```powershellImport-Module Microsoft.Graph.Security

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
This example shows how to use the Get-MgSecuritySecureScoreControlProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

