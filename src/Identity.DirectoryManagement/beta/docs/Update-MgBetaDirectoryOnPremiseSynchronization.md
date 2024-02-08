---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/update-mgbetadirectoryonpremisesynchronization
schema: 2.0.0
---

# Update-MgBetaDirectoryOnPremiseSynchronization

## SYNOPSIS
Update the properties of an onPremisesDirectorySynchronization object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDirectoryOnPremiseSynchronization -OnPremisesDirectorySynchronizationId <String>
 [-AdditionalProperties <Hashtable>]
 [-Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]
 [-Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaDirectoryOnPremiseSynchronization -OnPremisesDirectorySynchronizationId <String>
 -BodyParameter <IMicrosoftGraphOnPremisesDirectorySynchronization> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDirectoryOnPremiseSynchronization -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesDirectorySynchronization> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDirectoryOnPremiseSynchronization -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>]
 [-Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]
 [-Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of an onPremisesDirectorySynchronization object.

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
onPremisesDirectorySynchronization
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Configuration
onPremisesDirectorySynchronizationConfiguration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Features
onPremisesDirectorySynchronizationFeature
To construct, see NOTES section for FEATURES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronizationFeature
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnPremisesDirectorySynchronizationId
The unique identifier of onPremisesDirectorySynchronization

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphOnPremisesDirectorySynchronization>`: onPremisesDirectorySynchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
      - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
    - `[AnchorAttribute <String>]`: The anchor attribute allows customers to customize the property used to create source anchors for synchronization enabled objects.
    - `[ApplicationId <String>]`: The identifier of the on-premises directory synchronization client application that is configured for the tenant.
    - `[CurrentExportData <IMicrosoftGraphOnPremisesCurrentExportData>]`: onPremisesCurrentExportData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ClientMachineName <String>]`: The name of the onPremises client machine that ran the last export.
      - `[PendingObjectsAddition <Int32?>]`: The count of pending adds from on-premises directory.
      - `[PendingObjectsDeletion <Int32?>]`: The count of pending deletes from on-premises directory.
      - `[PendingObjectsUpdate <Int32?>]`: The count of pending updates from on-premises directory.
      - `[ServiceAccount <String>]`: The name of the dirsync service account that is configured to connect to the directory.
      - `[SuccessfulLinksProvisioningCount <Int64?>]`: The count of updated links during the current directory sync export run.
      - `[SuccessfulObjectsProvisioningCount <Int32?>]`: The count of objects that were successfully provisioned during the current directory sync export run.
      - `[TotalConnectorSpaceObjects <Int32?>]`: The total number of objects in the AAD Connector Space.
    - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: Interval of time that the customer requested the sync client waits between sync cycles.
    - `[SynchronizationClientVersion <String>]`: Indicates the version of the on-premises directory synchronization application.
    - `[SynchronizationInterval <TimeSpan?>]`: Interval of time the sync client should honor between sync cycles
    - `[WritebackConfiguration <IMicrosoftGraphOnPremisesWritebackConfiguration>]`: onPremisesWritebackConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UnifiedGroupContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store unified groups which are created in the cloud.
      - `[UserContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store users which are created in the cloud.
  - `[Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>]`: onPremisesDirectorySynchronizationFeature
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: Used to block cloud object takeover via source anchor hard match if enabled.
    - `[BlockSoftMatchEnabled <Boolean?>]`: Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.
    - `[BypassDirSyncOverridesEnabled <Boolean?>]`: When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Microsoft Entra ID.
    - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.
    - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: Used to enable concurrent user credentials update in OrgId.
    - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: Used to enable concurrent user creation in OrgId.
    - `[DeviceWritebackEnabled <Boolean?>]`: Used to indicate that device write-back is enabled.
    - `[DirectoryExtensionsEnabled <Boolean?>]`: Used to indicate that directory extensions are being synced from on-premises AD to Microsoft Entra ID.
    - `[FopeConflictResolutionEnabled <Boolean?>]`: Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.
    - `[GroupWriteBackEnabled <Boolean?>]`: Used to enable object-level group writeback feature for additional group types.
    - `[PasswordSyncEnabled <Boolean?>]`: Used to indicate on-premise password synchronization is enabled.
    - `[PasswordWritebackEnabled <Boolean?>]`: Used to indicate that writeback of password resets from Microsoft Entra ID to on-premises AD is enabled.
    - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects with conflicting proxy address.
    - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.
    - `[SoftMatchOnUpnEnabled <Boolean?>]`: Used to indicate that we should soft match objects based on userPrincipalName.
    - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.
    - `[UnifiedGroupWritebackEnabled <Boolean?>]`: Used to indicate that Microsoft 365 Group write-back is enabled.
    - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.
    - `[UserWritebackEnabled <Boolean?>]`: Used to indicate that user writeback is enabled.

`CONFIGURATION <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>`: onPremisesDirectorySynchronizationConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
    - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
  - `[AnchorAttribute <String>]`: The anchor attribute allows customers to customize the property used to create source anchors for synchronization enabled objects.
  - `[ApplicationId <String>]`: The identifier of the on-premises directory synchronization client application that is configured for the tenant.
  - `[CurrentExportData <IMicrosoftGraphOnPremisesCurrentExportData>]`: onPremisesCurrentExportData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ClientMachineName <String>]`: The name of the onPremises client machine that ran the last export.
    - `[PendingObjectsAddition <Int32?>]`: The count of pending adds from on-premises directory.
    - `[PendingObjectsDeletion <Int32?>]`: The count of pending deletes from on-premises directory.
    - `[PendingObjectsUpdate <Int32?>]`: The count of pending updates from on-premises directory.
    - `[ServiceAccount <String>]`: The name of the dirsync service account that is configured to connect to the directory.
    - `[SuccessfulLinksProvisioningCount <Int64?>]`: The count of updated links during the current directory sync export run.
    - `[SuccessfulObjectsProvisioningCount <Int32?>]`: The count of objects that were successfully provisioned during the current directory sync export run.
    - `[TotalConnectorSpaceObjects <Int32?>]`: The total number of objects in the AAD Connector Space.
  - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: Interval of time that the customer requested the sync client waits between sync cycles.
  - `[SynchronizationClientVersion <String>]`: Indicates the version of the on-premises directory synchronization application.
  - `[SynchronizationInterval <TimeSpan?>]`: Interval of time the sync client should honor between sync cycles
  - `[WritebackConfiguration <IMicrosoftGraphOnPremisesWritebackConfiguration>]`: onPremisesWritebackConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UnifiedGroupContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store unified groups which are created in the cloud.
    - `[UserContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store users which are created in the cloud.

`FEATURES <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>`: onPremisesDirectorySynchronizationFeature
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: Used to block cloud object takeover via source anchor hard match if enabled.
  - `[BlockSoftMatchEnabled <Boolean?>]`: Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.
  - `[BypassDirSyncOverridesEnabled <Boolean?>]`: When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Microsoft Entra ID.
  - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.
  - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: Used to enable concurrent user credentials update in OrgId.
  - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: Used to enable concurrent user creation in OrgId.
  - `[DeviceWritebackEnabled <Boolean?>]`: Used to indicate that device write-back is enabled.
  - `[DirectoryExtensionsEnabled <Boolean?>]`: Used to indicate that directory extensions are being synced from on-premises AD to Microsoft Entra ID.
  - `[FopeConflictResolutionEnabled <Boolean?>]`: Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.
  - `[GroupWriteBackEnabled <Boolean?>]`: Used to enable object-level group writeback feature for additional group types.
  - `[PasswordSyncEnabled <Boolean?>]`: Used to indicate on-premise password synchronization is enabled.
  - `[PasswordWritebackEnabled <Boolean?>]`: Used to indicate that writeback of password resets from Microsoft Entra ID to on-premises AD is enabled.
  - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects with conflicting proxy address.
  - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.
  - `[SoftMatchOnUpnEnabled <Boolean?>]`: Used to indicate that we should soft match objects based on userPrincipalName.
  - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.
  - `[UnifiedGroupWritebackEnabled <Boolean?>]`: Used to indicate that Microsoft 365 Group write-back is enabled.
  - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.
  - `[UserWritebackEnabled <Boolean?>]`: Used to indicate that user writeback is enabled.

`INPUTOBJECT <IIdentityDirectoryManagementIdentity>`: Identity Parameter
  - `[AdministrativeUnitId <String>]`: The unique identifier of administrativeUnit
  - `[AllowedValueId <String>]`: The unique identifier of allowedValue
  - `[AttributeSetId <String>]`: The unique identifier of attributeSet
  - `[CertificateAuthorityAsEntityId <String>]`: The unique identifier of certificateAuthorityAsEntity
  - `[CertificateBasedApplicationConfigurationId <String>]`: The unique identifier of certificateBasedApplicationConfiguration
  - `[CommandId <String>]`: The unique identifier of command
  - `[CompanySubscriptionId <String>]`: The unique identifier of companySubscription
  - `[ContractId <String>]`: The unique identifier of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: The unique identifier of customSecurityAttributeDefinition
  - `[DeviceId <String>]`: The unique identifier of device
  - `[DeviceLocalCredentialInfoId <String>]`: The unique identifier of deviceLocalCredentialInfo
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectoryRoleId <String>]`: The unique identifier of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: The unique identifier of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: The unique identifier of directorySetting
  - `[DirectorySettingTemplateId <String>]`: The unique identifier of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: The unique identifier of domainDnsRecord
  - `[DomainId <String>]`: The unique identifier of domain
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[FeatureRolloutPolicyId <String>]`: The unique identifier of featureRolloutPolicy
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[ImpactedResourceId <String>]`: The unique identifier of impactedResource
  - `[InboundSharedUserProfileUserId <String>]`: The unique identifier of inboundSharedUserProfile
  - `[InternalDomainFederationId <String>]`: The unique identifier of internalDomainFederation
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[OnPremisesDirectorySynchronizationId <String>]`: The unique identifier of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: The unique identifier of orgContact
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: The unique identifier of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: The unique identifier of outboundSharedUserProfile
  - `[ProfileCardPropertyId <String>]`: The unique identifier of profileCardProperty
  - `[RecommendationId <String>]`: The unique identifier of recommendation
  - `[RoleTemplateId <String>]`: Alternate key of directoryRole
  - `[ScopedRoleMembershipId <String>]`: The unique identifier of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: The unique identifier of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: The unique identifier of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: The unique identifier of subscribedSku
  - `[TenantId <String>]`: The unique identifier of tenant
  - `[TenantReferenceTenantId <String>]`: The unique identifier of tenantReference
  - `[TenantTagId <String>]`: The unique identifier of tenantTag
  - `[UsageRightId <String>]`: The unique identifier of usageRight
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

