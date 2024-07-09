### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.vppToken"
	organizationName = "Organization Name value"
	vppTokenAccountType = "education"
	appleId = "Apple Id value"
	expirationDateTime = [System.DateTime]::Parse("2016-12-31T23:57:57.2481234-08:00")
	lastSyncDateTime = [System.DateTime]::Parse("2017-01-01T00:02:49.3205976-08:00")
	token = "Token value"
	state = "valid"
	lastSyncStatus = "inProgress"
	automaticallyUpdateApps = $true
	countryOrRegion = "Country Or Region value"
}

Update-MgDeviceAppManagementVppToken -VppTokenId $vppTokenId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementVppToken Cmdlet.

