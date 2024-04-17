---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.corporatemanagement/invoke-mgcommitdeviceappmanagementmobileappmicrosoftgraphwindowsmobilemsicontentversionfile
schema: 2.0.0
---

# Invoke-MgCommitDeviceAppManagementMobileAppMicrosoftGraphWindowsMobileMsiContentVersionFile

## SYNOPSIS
Commits a file of a given app.

## SYNTAX

### CommitExpanded (Default)
```
Invoke-MgCommitDeviceAppManagementMobileAppMicrosoftGraphWindowsMobileMsiContentVersionFile
 -MobileAppContentFileId <String> -MobileAppContentId <String> -MobileAppId <String>
 [-AdditionalProperties <Hashtable>] [-FileEncryptionInfo <IMicrosoftGraphFileEncryptionInfo>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Commit
```
Invoke-MgCommitDeviceAppManagementMobileAppMicrosoftGraphWindowsMobileMsiContentVersionFile
 -MobileAppContentFileId <String> -MobileAppContentId <String> -MobileAppId <String>
 -BodyParameter <IPathsQ8G1SgDeviceappmanagementMobileappsMobileappIdMicrosoftGraphWindowsmobilemsiContentversionsMobileappcontentIdFilesMobileappcontentfileIdMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CommitViaIdentity
```
Invoke-MgCommitDeviceAppManagementMobileAppMicrosoftGraphWindowsMobileMsiContentVersionFile
 -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IPathsQ8G1SgDeviceappmanagementMobileappsMobileappIdMicrosoftGraphWindowsmobilemsiContentversionsMobileappcontentIdFilesMobileappcontentfileIdMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CommitViaIdentityExpanded
```
Invoke-MgCommitDeviceAppManagementMobileAppMicrosoftGraphWindowsMobileMsiContentVersionFile
 -InputObject <IDevicesCorporateManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-FileEncryptionInfo <IMicrosoftGraphFileEncryptionInfo>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Commits a file of a given app.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CommitExpanded, CommitViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsQ8G1SgDeviceappmanagementMobileappsMobileappIdMicrosoftGraphWindowsmobilemsiContentversionsMobileappcontentIdFilesMobileappcontentfileIdMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Commit, CommitViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FileEncryptionInfo
Contains properties for file encryption information for the content version of a line of business app.
To construct, see NOTES section for FILEENCRYPTIONINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileEncryptionInfo
Parameter Sets: CommitExpanded, CommitViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: CommitViaIdentity, CommitViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MobileAppContentFileId
The unique identifier of mobileAppContentFile

```yaml
Type: System.String
Parameter Sets: Commit, CommitExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppContentId
The unique identifier of mobileAppContent

```yaml
Type: System.String
Parameter Sets: Commit, CommitExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppId
The unique identifier of mobileApp

```yaml
Type: System.String
Parameter Sets: Commit, CommitExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IPathsQ8G1SgDeviceappmanagementMobileappsMobileappIdMicrosoftGraphWindowsmobilemsiContentversionsMobileappcontentIdFilesMobileappcontentfileIdMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsQ8G1SgDeviceappmanagementMobileappsMobileappIdMicrosoftGraphWindowsmobilemsiContentversionsMobileappcontentIdFilesMobileappcontentfileIdMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FileEncryptionInfo <IMicrosoftGraphFileEncryptionInfo>]`: Contains properties for file encryption information for the content version of a line of business app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EncryptionKey <Byte[]>]`: The key used to encrypt the file content.
    - `[FileDigest <Byte[]>]`: The file digest prior to encryption. ProfileVersion1 requires a non-null FileDigest.
    - `[FileDigestAlgorithm <String>]`: The file digest algorithm. ProfileVersion1 currently only supports SHA256 for the FileDigestAlgorithm.
    - `[InitializationVector <Byte[]>]`: The initialization vector (IV) used for the encryption algorithm. Must be 16 bytes.
    - `[Mac <Byte[]>]`: The hash of the concatenation of the IV and encrypted file content. Must be 32 bytes.
    - `[MacKey <Byte[]>]`: The key used to compute the message authentication code of the concatenation of the IV and encrypted file content. Must be 32 bytes.
    - `[ProfileIdentifier <String>]`: The profile identifier. Maps to the strategy used to encrypt the file. Currently, only ProfileVersion1 is supported.

`FILEENCRYPTIONINFO <IMicrosoftGraphFileEncryptionInfo>`: Contains properties for file encryption information for the content version of a line of business app.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EncryptionKey <Byte[]>]`: The key used to encrypt the file content.
  - `[FileDigest <Byte[]>]`: The file digest prior to encryption. ProfileVersion1 requires a non-null FileDigest.
  - `[FileDigestAlgorithm <String>]`: The file digest algorithm. ProfileVersion1 currently only supports SHA256 for the FileDigestAlgorithm.
  - `[InitializationVector <Byte[]>]`: The initialization vector (IV) used for the encryption algorithm. Must be 16 bytes.
  - `[Mac <Byte[]>]`: The hash of the concatenation of the IV and encrypted file content. Must be 32 bytes.
  - `[MacKey <Byte[]>]`: The key used to compute the message authentication code of the concatenation of the IV and encrypted file content. Must be 32 bytes.
  - `[ProfileIdentifier <String>]`: The profile identifier. Maps to the strategy used to encrypt the file. Currently, only ProfileVersion1 is supported.

`INPUTOBJECT <IDevicesCorporateManagementIdentity>`: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: The unique identifier of androidManagedAppProtection
  - `[DefaultManagedAppProtectionId <String>]`: The unique identifier of defaultManagedAppProtection
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceInstallStateId <String>]`: The unique identifier of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[IosManagedAppProtectionId <String>]`: The unique identifier of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: The unique identifier of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: The unique identifier of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: The unique identifier of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: The unique identifier of managedAppStatus
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: The unique identifier of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: The unique identifier of managedEBookAssignment
  - `[ManagedEBookId <String>]`: The unique identifier of managedEBook
  - `[ManagedMobileAppId <String>]`: The unique identifier of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: The unique identifier of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: The unique identifier of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: The unique identifier of mobileAppCategory
  - `[MobileAppContentFileId <String>]`: The unique identifier of mobileAppContentFile
  - `[MobileAppContentId <String>]`: The unique identifier of mobileAppContent
  - `[MobileAppId <String>]`: The unique identifier of mobileApp
  - `[MobileContainedAppId <String>]`: The unique identifier of mobileContainedApp
  - `[TargetedManagedAppConfigurationId <String>]`: The unique identifier of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: The unique identifier of targetedManagedAppPolicyAssignment
  - `[UserId <String>]`: The unique identifier of user
  - `[UserInstallStateSummaryId <String>]`: The unique identifier of userInstallStateSummary
  - `[VppTokenId <String>]`: The unique identifier of vppToken
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLockerFileId <String>]`: The unique identifier of windowsInformationProtectionAppLockerFile
  - `[WindowsInformationProtectionPolicyId <String>]`: The unique identifier of windowsInformationProtectionPolicy

## RELATED LINKS

