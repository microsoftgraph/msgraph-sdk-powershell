### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	deletedUserPersonalSiteRetentionPeriodInDays = 365
	excludedFileExtensionsForSyncApp = @(
	".mp3"
)
imageTaggingOption = "enhanced"
isLegacyAuthProtocolsEnabled = $true
isSitesStorageLimitAutomatic = $false
isSyncButtonHiddenOnPersonalSite = $false
isUnmanagedSyncAppForTenantRestricted = $false
personalSiteDefaultStorageLimitInMB = 120000
}

Update-MgAdminSharepointSetting -BodyParameter $params

```
This example shows how to use the Update-MgAdminSharepointSetting Cmdlet.

