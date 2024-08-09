### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windows10EndpointProtectionConfiguration"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	firewallBlockStatefulFTP = $true
	firewallIdleTimeoutForSecurityAssociationInSeconds = 
	firewallPreSharedKeyEncodingMethod = "none"
	firewallIPSecExemptionsAllowNeighborDiscovery = $true
	firewallIPSecExemptionsAllowICMP = $true
	firewallIPSecExemptionsAllowRouterDiscovery = $true
	firewallIPSecExemptionsAllowDHCP = $true
	firewallCertificateRevocationListCheckMethod = "none"
	firewallMergeKeyingModuleSettings = $true
	firewallPacketQueueingMethod = "disabled"
	firewallProfileDomain = @{
		"@odata.type" = "microsoft.graph.windowsFirewallNetworkProfile"
		firewallEnabled = "blocked"
		stealthModeBlocked = $true
		incomingTrafficBlocked = $true
		unicastResponsesToMulticastBroadcastsBlocked = $true
		inboundNotificationsBlocked = $true
		authorizedApplicationRulesFromGroupPolicyMerged = $true
		globalPortRulesFromGroupPolicyMerged = $true
		connectionSecurityRulesFromGroupPolicyMerged = $true
		outboundConnectionsBlocked = $true
		inboundConnectionsBlocked = $true
		securedPacketExemptionAllowed = $true
		policyRulesFromGroupPolicyMerged = $true
	}
	firewallProfilePublic = @{
		"@odata.type" = "microsoft.graph.windowsFirewallNetworkProfile"
		firewallEnabled = "blocked"
		stealthModeBlocked = $true
		incomingTrafficBlocked = $true
		unicastResponsesToMulticastBroadcastsBlocked = $true
		inboundNotificationsBlocked = $true
		authorizedApplicationRulesFromGroupPolicyMerged = $true
		globalPortRulesFromGroupPolicyMerged = $true
		connectionSecurityRulesFromGroupPolicyMerged = $true
		outboundConnectionsBlocked = $true
		inboundConnectionsBlocked = $true
		securedPacketExemptionAllowed = $true
		policyRulesFromGroupPolicyMerged = $true
	}
	firewallProfilePrivate = @{
		"@odata.type" = "microsoft.graph.windowsFirewallNetworkProfile"
		firewallEnabled = "blocked"
		stealthModeBlocked = $true
		incomingTrafficBlocked = $true
		unicastResponsesToMulticastBroadcastsBlocked = $true
		inboundNotificationsBlocked = $true
		authorizedApplicationRulesFromGroupPolicyMerged = $true
		globalPortRulesFromGroupPolicyMerged = $true
		connectionSecurityRulesFromGroupPolicyMerged = $true
		outboundConnectionsBlocked = $true
		inboundConnectionsBlocked = $true
		securedPacketExemptionAllowed = $true
		policyRulesFromGroupPolicyMerged = $true
	}
	defenderAttackSurfaceReductionExcludedPaths = @(
	"Defender Attack Surface Reduction Excluded Paths value"
)
defenderGuardedFoldersAllowedAppPaths = @(
"Defender Guarded Folders Allowed App Paths value"
)
defenderAdditionalGuardedFolders = @(
"Defender Additional Guarded Folders value"
)
defenderExploitProtectionXml = "ZGVmZW5kZXJFeHBsb2l0UHJvdGVjdGlvblhtbA=="
defenderExploitProtectionXmlFileName = "Defender Exploit Protection Xml File Name value"
defenderSecurityCenterBlockExploitProtectionOverride = $true
appLockerApplicationControl = "enforceComponentsAndStoreApps"
smartScreenEnableInShell = $true
smartScreenBlockOverrideForFiles = $true
applicationGuardEnabled = $true
applicationGuardBlockFileTransfer = "blockImageAndTextFile"
applicationGuardBlockNonEnterpriseContent = $true
applicationGuardAllowPersistence = $true
applicationGuardForceAuditing = $true
applicationGuardBlockClipboardSharing = "blockBoth"
applicationGuardAllowPrintToPDF = $true
applicationGuardAllowPrintToXPS = $true
applicationGuardAllowPrintToLocalPrinters = $true
applicationGuardAllowPrintToNetworkPrinters = $true
bitLockerDisableWarningForOtherDiskEncryption = $true
bitLockerEnableStorageCardEncryptionOnMobile = $true
bitLockerEncryptDevice = $true
bitLockerRemovableDrivePolicy = @{
"@odata.type" = "microsoft.graph.bitLockerRemovableDrivePolicy"
encryptionMethod = "aesCbc256"
requireEncryptionForWriteAccess = $true
blockCrossOrganizationWriteAccess = $true
}
}

New-MgDeviceManagementDeviceConfiguration -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceConfiguration Cmdlet.

