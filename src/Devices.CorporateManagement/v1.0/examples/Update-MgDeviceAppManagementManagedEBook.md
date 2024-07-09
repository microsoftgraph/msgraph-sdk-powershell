### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.iosVppEBook"
	displayName = "Display Name value"
	description = "Description value"
	publisher = "Publisher value"
	publishedDateTime = [System.DateTime]::Parse("2016-12-31T23:58:16.1180489-08:00")
	largeCover = @{
		"@odata.type" = "microsoft.graph.mimeContent"
		type = "Type value"
		value = [System.Text.Encoding]::ASCII.GetBytes("dmFsdWU=")
	}
	informationUrl = "https://example.com/informationUrl/"
	privacyInformationUrl = "https://example.com/privacyInformationUrl/"
	vppTokenId = "9148ac60-ac60-9148-60ac-489160ac4891"
	appleId = "Apple Id value"
	vppOrganizationName = "Vpp Organization Name value"
	genres = @(
	"Genres value"
)
language = "Language value"
seller = "Seller value"
totalLicenseCount = 
usedLicenseCount = 
}

Update-MgDeviceAppManagementManagedEBook -ManagedEBookId $managedEBookId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementManagedEBook Cmdlet.

