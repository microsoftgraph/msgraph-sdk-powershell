---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.sites/update-mgadminsharepointsetting
schema: 2.0.0
---

# Update-MgAdminSharepointSetting

## SYNOPSIS
Update one or more tenant-level settings for SharePoint and OneDrive.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAdminSharepointSetting [-AdditionalProperties <Hashtable>] [-AllowedDomainGuidsForSyncApp <String[]>]
 [-AvailableManagedPathsForSiteCreation <String[]>] [-DeletedUserPersonalSiteRetentionPeriodInDays <Int32>]
 [-ExcludedFileExtensionsForSyncApp <String[]>] [-Id <String>]
 [-IdleSessionSignOut <IMicrosoftGraphIdleSessionSignOut>] [-ImageTaggingOption <String>]
 [-IsCommentingOnSitePagesEnabled] [-IsFileActivityNotificationEnabled] [-IsLegacyAuthProtocolsEnabled]
 [-IsLoopEnabled] [-IsMacSyncAppEnabled] [-IsRequireAcceptingUserToMatchInvitedUserEnabled]
 [-IsResharingByExternalUsersEnabled] [-IsSharePointMobileNotificationEnabled] [-IsSharePointNewsfeedEnabled]
 [-IsSiteCreationEnabled] [-IsSiteCreationUiEnabled] [-IsSitePagesCreationEnabled]
 [-IsSitesStorageLimitAutomatic] [-IsSyncButtonHiddenOnPersonalSite] [-IsUnmanagedSyncAppForTenantRestricted]
 [-PersonalSiteDefaultStorageLimitInMb <Int64>] [-SharingAllowedDomainList <String[]>]
 [-SharingBlockedDomainList <String[]>] [-SharingCapability <String>] [-SharingDomainRestrictionMode <String>]
 [-SiteCreationDefaultManagedPath <String>] [-SiteCreationDefaultStorageLimitInMb <Int32>]
 [-TenantDefaultTimezone <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgAdminSharepointSetting -BodyParameter <IMicrosoftGraphSharepointSettings> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update one or more tenant-level settings for SharePoint and OneDrive.

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedDomainGuidsForSyncApp
Collection of trusted domain GUIDs for the OneDrive sync app.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailableManagedPathsForSiteCreation
Collection of managed paths available for site creation.
Read-only.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sharepointSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharepointSettings
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedUserPersonalSiteRetentionPeriodInDays
The number of days for preserving a deleted user's OneDrive.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludedFileExtensionsForSyncApp
Collection of file extensions not uploaded by the OneDrive sync app.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdleSessionSignOut
idleSessionSignOut
To construct, see NOTES section for IDLESESSIONSIGNOUT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdleSessionSignOut
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageTaggingOption
imageTaggingChoice

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsCommentingOnSitePagesEnabled
Indicates whether comments are allowed on modern site pages in SharePoint.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsFileActivityNotificationEnabled
Indicates whether push notifications are enabled for OneDrive events.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsLegacyAuthProtocolsEnabled
Indicates whether legacy authentication protocols are enabled for the tenant.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsLoopEnabled
Indicates whether if Fluid Framework is allowed on SharePoint sites.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsMacSyncAppEnabled
Indicates whether files can be synced using the OneDrive sync app for Mac.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRequireAcceptingUserToMatchInvitedUserEnabled
Indicates whether guests must sign in using the same account to which sharing invitations are sent.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsResharingByExternalUsersEnabled
Indicates whether guests are allowed to reshare files, folders, and sites they don't own.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSharePointMobileNotificationEnabled
Indicates whether mobile push notifications are enabled for SharePoint.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSharePointNewsfeedEnabled
Indicates whether the newsfeed is allowed on the modern site pages in SharePoint.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSiteCreationEnabled
Indicates whether users are allowed to create sites.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSiteCreationUiEnabled
Indicates whether the UI commands for creating sites are shown.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSitePagesCreationEnabled
Indicates whether creating new modern pages is allowed on SharePoint sites.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSitesStorageLimitAutomatic
Indicates whether site storage space is automatically managed or if specific storage limits are set per site.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSyncButtonHiddenOnPersonalSite
Indicates whether the sync button in OneDrive is hidden.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsUnmanagedSyncAppForTenantRestricted
Indicates whether users are allowed to sync files only on PCs joined to specific domains.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonalSiteDefaultStorageLimitInMb
The default OneDrive storage limit for all new and existing users who are assigned a qualifying license.
Measured in megabytes (MB).

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingAllowedDomainList
Collection of email domains that are allowed for sharing outside the organization.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingBlockedDomainList
Collection of email domains that are blocked for sharing outside the organization.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingCapability
sharingCapabilities

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingDomainRestrictionMode
sharingDomainRestrictionMode

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCreationDefaultManagedPath
The value of the team site managed path.
This is the path under which new team sites will be created.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCreationDefaultStorageLimitInMb
The default storage quota for a new site upon creation.
Measured in megabytes (MB).

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantDefaultTimezone
The default timezone of a tenant for newly created sites.
For a list of possible values, see SPRegionalSettings.TimeZones property.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharepointSettings

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharepointSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSharepointSettings>`: sharepointSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedDomainGuidsForSyncApp <String[]>]`: Collection of trusted domain GUIDs for the OneDrive sync app.
  - `[AvailableManagedPathsForSiteCreation <String[]>]`: Collection of managed paths available for site creation. Read-only.
  - `[DeletedUserPersonalSiteRetentionPeriodInDays <Int32?>]`: The number of days for preserving a deleted user's OneDrive.
  - `[ExcludedFileExtensionsForSyncApp <String[]>]`: Collection of file extensions not uploaded by the OneDrive sync app.
  - `[IdleSessionSignOut <IMicrosoftGraphIdleSessionSignOut>]`: idleSessionSignOut
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Indicates whether the idle session sign-out policy is enabled.
    - `[SignOutAfterInSeconds <Int64?>]`: Number of seconds of inactivity after which a user is signed out.
    - `[WarnAfterInSeconds <Int64?>]`: Number of seconds of inactivity after which a user is notified that they'll be signed out.
  - `[ImageTaggingOption <String>]`: imageTaggingChoice
  - `[IsCommentingOnSitePagesEnabled <Boolean?>]`: Indicates whether comments are allowed on modern site pages in SharePoint.
  - `[IsFileActivityNotificationEnabled <Boolean?>]`: Indicates whether push notifications are enabled for OneDrive events.
  - `[IsLegacyAuthProtocolsEnabled <Boolean?>]`: Indicates whether legacy authentication protocols are enabled for the tenant.
  - `[IsLoopEnabled <Boolean?>]`: Indicates whether if Fluid Framework is allowed on SharePoint sites.
  - `[IsMacSyncAppEnabled <Boolean?>]`: Indicates whether files can be synced using the OneDrive sync app for Mac.
  - `[IsRequireAcceptingUserToMatchInvitedUserEnabled <Boolean?>]`: Indicates whether guests must sign in using the same account to which sharing invitations are sent.
  - `[IsResharingByExternalUsersEnabled <Boolean?>]`: Indicates whether guests are allowed to reshare files, folders, and sites they don't own.
  - `[IsSharePointMobileNotificationEnabled <Boolean?>]`: Indicates whether mobile push notifications are enabled for SharePoint.
  - `[IsSharePointNewsfeedEnabled <Boolean?>]`: Indicates whether the newsfeed is allowed on the modern site pages in SharePoint.
  - `[IsSiteCreationEnabled <Boolean?>]`: Indicates whether users are allowed to create sites.
  - `[IsSiteCreationUiEnabled <Boolean?>]`: Indicates whether the UI commands for creating sites are shown.
  - `[IsSitePagesCreationEnabled <Boolean?>]`: Indicates whether creating new modern pages is allowed on SharePoint sites.
  - `[IsSitesStorageLimitAutomatic <Boolean?>]`: Indicates whether site storage space is automatically managed or if specific storage limits are set per site.
  - `[IsSyncButtonHiddenOnPersonalSite <Boolean?>]`: Indicates whether the sync button in OneDrive is hidden.
  - `[IsUnmanagedSyncAppForTenantRestricted <Boolean?>]`: Indicates whether users are allowed to sync files only on PCs joined to specific domains.
  - `[PersonalSiteDefaultStorageLimitInMb <Int64?>]`: The default OneDrive storage limit for all new and existing users who are assigned a qualifying license. Measured in megabytes (MB).
  - `[SharingAllowedDomainList <String[]>]`: Collection of email domains that are allowed for sharing outside the organization.
  - `[SharingBlockedDomainList <String[]>]`: Collection of email domains that are blocked for sharing outside the organization.
  - `[SharingCapability <String>]`: sharingCapabilities
  - `[SharingDomainRestrictionMode <String>]`: sharingDomainRestrictionMode
  - `[SiteCreationDefaultManagedPath <String>]`: The value of the team site managed path. This is the path under which new team sites will be created.
  - `[SiteCreationDefaultStorageLimitInMb <Int32?>]`: The default storage quota for a new site upon creation. Measured in megabytes (MB).
  - `[TenantDefaultTimezone <String>]`: The default timezone of a tenant for newly created sites. For a list of possible values, see SPRegionalSettings.TimeZones property.

`IDLESESSIONSIGNOUT <IMicrosoftGraphIdleSessionSignOut>`: idleSessionSignOut
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsEnabled <Boolean?>]`: Indicates whether the idle session sign-out policy is enabled.
  - `[SignOutAfterInSeconds <Int64?>]`: Number of seconds of inactivity after which a user is signed out.
  - `[WarnAfterInSeconds <Int64?>]`: Number of seconds of inactivity after which a user is notified that they'll be signed out.

## RELATED LINKS

