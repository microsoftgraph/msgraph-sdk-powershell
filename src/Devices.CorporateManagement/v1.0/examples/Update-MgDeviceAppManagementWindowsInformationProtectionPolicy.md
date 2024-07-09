### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsInformationProtectionPolicy"
	displayName = "Display Name value"
	description = "Description value"
	version = "Version value"
	enforcementLevel = "encryptAndAuditOnly"
	enterpriseDomain = "Enterprise Domain value"
	enterpriseProtectedDomainNames = @(
		@{
			"@odata.type" = "microsoft.graph.windowsInformationProtectionResourceCollection"
			displayName = "Display Name value"
			resources = @(
			"Resources value"
		)
	}
)
protectionUnderLockConfigRequired = $true
dataRecoveryCertificate = @{
	"@odata.type" = "microsoft.graph.windowsInformationProtectionDataRecoveryCertificate"
	subjectName = "Subject Name value"
	description = "Description value"
	expirationDateTime = [System.DateTime]::Parse("2016-12-31T23:57:57.2481234-08:00")
	certificate = [System.Text.Encoding]::ASCII.GetBytes("Y2VydGlmaWNhdGU=")
}
revokeOnUnenrollDisabled = $true
rightsManagementServicesTemplateId = "abf7b16f-b16f-abf7-6fb1-f7ab6fb1f7ab"
azureRightsManagementServicesAllowed = $true
iconsVisible = $true
protectedApps = @(
	@{
		"@odata.type" = "microsoft.graph.windowsInformationProtectionStoreApp"
		displayName = "Display Name value"
		description = "Description value"
		publisherName = "Publisher Name value"
		productName = "Product Name value"
		denied = $true
	}
)
exemptApps = @(
	@{
		"@odata.type" = "microsoft.graph.windowsInformationProtectionStoreApp"
		displayName = "Display Name value"
		description = "Description value"
		publisherName = "Publisher Name value"
		productName = "Product Name value"
		denied = $true
	}
)
enterpriseNetworkDomainNames = @(
	@{
		"@odata.type" = "microsoft.graph.windowsInformationProtectionResourceCollection"
		displayName = "Display Name value"
		resources = @(
		"Resources value"
	)
}
)
enterpriseProxiedDomains = @(
@{
	"@odata.type" = "microsoft.graph.windowsInformationProtectionProxiedDomainCollection"
	displayName = "Display Name value"
	proxiedDomains = @(
		@{
			"@odata.type" = "microsoft.graph.proxiedDomain"
			ipAddressOrFQDN = "Ip Address Or FQDN value"
			proxy = "Proxy value"
		}
	)
}
)
enterpriseIPRanges = @(
@{
	"@odata.type" = "microsoft.graph.windowsInformationProtectionIPRangeCollection"
	displayName = "Display Name value"
	ranges = @(
		@{
			"@odata.type" = "microsoft.graph.ipRange"
		}
	)
}
)
enterpriseIPRangesAreAuthoritative = $true
enterpriseProxyServers = @(
@{
	"@odata.type" = "microsoft.graph.windowsInformationProtectionResourceCollection"
	displayName = "Display Name value"
	resources = @(
	"Resources value"
)
}
)
enterpriseInternalProxyServers = @(
@{
"@odata.type" = "microsoft.graph.windowsInformationProtectionResourceCollection"
displayName = "Display Name value"
resources = @(
"Resources value"
)
}
)
enterpriseProxyServersAreAuthoritative = $true
neutralDomainResources = @(
@{
"@odata.type" = "microsoft.graph.windowsInformationProtectionResourceCollection"
displayName = "Display Name value"
resources = @(
"Resources value"
)
}
)
indexingEncryptedStoresOrItemsBlocked = $true
smbAutoEncryptedFileExtensions = @(
@{
"@odata.type" = "microsoft.graph.windowsInformationProtectionResourceCollection"
displayName = "Display Name value"
resources = @(
"Resources value"
)
}
)
isAssigned = $true
revokeOnMdmHandoffDisabled = $true
mdmEnrollmentUrl = "https://example.com/mdmEnrollmentUrl/"
windowsHelloForBusinessBlocked = $true
pinMinimumLength = 0
pinUppercaseLetters = "requireAtLeastOne"
pinLowercaseLetters = "requireAtLeastOne"
pinSpecialCharacters = "requireAtLeastOne"
pinExpirationDays = 1
numberOfPastPinsRemembered = 10
passwordMaximumAttemptCount = 11
minutesOfInactivityBeforeDeviceLock = 3
daysWithoutContactBeforeUnenroll = 0
}

Update-MgDeviceAppManagementWindowsInformationProtectionPolicy -WindowsInformationProtectionPolicyId $windowsInformationProtectionPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementWindowsInformationProtectionPolicy Cmdlet.

