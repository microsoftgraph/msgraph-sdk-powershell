### Example 1: Create a new device template

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	mutualTlsOauthConfigurationId = "00001111-aaaa-2222-bbbb-3333cccc4444"
	mutualTlsOauthConfigurationTenantId = "00001111-aaaa-2222-bbbb-3333cccc4445"
	deviceAuthority = "Lakeshore Retail"
	manufacturer = "Tailwind Traders"
	model = "DeepFreezerModelAB"
	operatingSystem = "WindowsIoT"
}

New-MgBetaDirectoryTemplateDeviceTemplate -BodyParameter $params

```
This example will create a new device template

### Example 2: Create a device template with an owner

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	mutualTlsOauthConfigurationId = "00001111-aaaa-2222-bbbb-3333cccc4444"
	mutualTlsOauthConfigurationTenantId = "00001111-aaaa-2222-bbbb-3333cccc4445"
	deviceAuthority = "Lakeshore Retail"
	manufacturer = "Tailwind Traders"
	model = "DeepFreezerModelAB"
	operatingSystem = "WindowsIoT"
	"owners@odata.bind" = @(
	"https://graph.microsoft.com/beta/users/aaaaaaaa-bbbb-cccc-1111-222222222222"
)
}

New-MgBetaDirectoryTemplateDeviceTemplate -BodyParameter $params

```
This example will create a device template with an owner

