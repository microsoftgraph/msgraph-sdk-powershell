### Example 1: Using the Update-MgSecuritySecureScoreControlProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	AssignedTo = ""
	Comment = "control is reviewed"
	State = "Reviewed"
	VendorInformation = @{
		Provider = "SecureScore"
		ProviderVersion = $null
		SubProvider = $null
		Vendor = "Microsoft"
	}
}
Update-MgSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params
```
This example shows how to use the Update-MgSecuritySecureScoreControlProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgSecuritySecureScoreControlProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	AssignedTo = ""
	Comment = "control is reviewed"
	State = "Reviewed"
	VendorInformation = @{
		Provider = "SecureScore"
		ProviderVersion = $null
		SubProvider = $null
		Vendor = "Microsoft"
	}
}
Update-MgSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params
```
This example shows how to use the Update-MgSecuritySecureScoreControlProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
