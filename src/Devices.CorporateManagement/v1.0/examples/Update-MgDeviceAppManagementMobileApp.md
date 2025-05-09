### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.win32LobApp"
	displayName = "Display Name value"
	description = "Description value"
	publisher = "Publisher value"
	largeIcon = @{
		"@odata.type" = "microsoft.graph.mimeContent"
		type = "Type value"
		value = [System.Text.Encoding]::ASCII.GetBytes("dmFsdWU=")
	}
	isFeatured = $true
	privacyInformationUrl = "https://example.com/privacyInformationUrl/"
	informationUrl = "https://example.com/informationUrl/"
	owner = "Owner value"
	developer = "Developer value"
	notes = "Notes value"
	publishingState = "processing"
	committedContentVersion = "Committed Content Version value"
	fileName = "File Name value"
	size = 
	installCommandLine = "Install Command Line value"
	uninstallCommandLine = "Uninstall Command Line value"
	applicableArchitectures = "x86"
	minimumFreeDiskSpaceInMB = 
	minimumMemoryInMB = 
	minimumNumberOfProcessors = 
	minimumCpuSpeedInMHz = 
	rules = @(
		@{
			"@odata.type" = "microsoft.graph.win32LobAppRegistryRule"
			ruleType = "requirement"
			check32BitOn64System = $true
			keyPath = "Key Path value"
			valueName = "Value Name value"
			operationType = "exists"
			operator = "equal"
			comparisonValue = "Comparison Value value"
		}
	)
	installExperience = @{
		"@odata.type" = "microsoft.graph.win32LobAppInstallExperience"
		runAsAccount = "user"
		deviceRestartBehavior = "allow"
	}
	returnCodes = @(
		@{
			"@odata.type" = "microsoft.graph.win32LobAppReturnCode"
			returnCode = 
			type = "success"
		}
	)
	msiInformation = @{
		"@odata.type" = "microsoft.graph.win32LobAppMsiInformation"
		productCode = "Product Code value"
		productVersion = "Product Version value"
		upgradeCode = "Upgrade Code value"
		requiresReboot = $true
		packageType = "perUser"
		productName = "Product Name value"
		publisher = "Publisher value"
	}
	setupFilePath = "Setup File Path value"
	minimumSupportedWindowsRelease = "Minimum Supported Windows Release value"
}

Update-MgDeviceAppManagementMobileApp -MobileAppId $mobileAppId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementMobileApp Cmdlet.

