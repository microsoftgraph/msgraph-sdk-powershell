### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	"@odata.type" = "#microsoft.graph.industryData.oneRosterApiDataConnector"
	displayName = "Generic OAuth2 Connector"
	"sourceSystem@odata.bind" = "https://graph.microsoft.com/beta/external/industryData/sourceSystems('c93a6e02-aeb7-437f-cc52-08dc3fc158af')"
	apiFormat = "oneRoster"
	baseUrl = "https://fakeProvider.net/ims/oneroster/v1p1"
	apiVersion = "1.1"
	credential = @{
		"@odata.type" = "#microsoft.graph.industryData.oAuth2ClientCredential"
		displayName = "One Roster API Credentials"
		clientId = "530be723-6af3-4952-8658-668fb2598ad7"
		clientSecret = "thisIsASecret"
		tokenUrl = "https://login.microsoftonline.com/c27f982b-f7ee-4b8b-bb0e-3c55bd1dc02c/oauth2/token"
		scope = $null
	}
	isDemographicsEnabled = $false
	isFlagsEnabled = $false
	isContactsEnabled = $false
}

New-MgBetaExternalIndustryDataConnector -BodyParameter $params

```
This example shows how to use the New-MgBetaExternalIndustryDataConnector Cmdlet.

