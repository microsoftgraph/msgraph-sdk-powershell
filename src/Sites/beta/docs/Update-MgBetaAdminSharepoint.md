---
external help file:
Module Name: Microsoft.Graph.Beta.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.sites/update-mgbetaadminsharepoint
schema: 2.0.0
---

# Update-MgBetaAdminSharepoint

## SYNOPSIS
Update the navigation property sharepoint in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaAdminSharepoint [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-ResponseHeadersVariable <String>] [-Settings <IMicrosoftGraphSharepointSettings>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaAdminSharepoint -BodyParameter <IMicrosoftGraphSharepoint> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property sharepoint in admin

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

### -BodyParameter
sharepoint
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharepoint
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Settings
sharepointSettings
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharepointSettings
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharepoint

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharepoint

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSharepoint>`: sharepoint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Settings <IMicrosoftGraphSharepointSettings>]`: sharepointSettings
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
    - `[IsLoopEnabled <Boolean?>]`: Indicates whetherif Fluid Framework is allowed on SharePoint sites.
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

`SETTINGS <IMicrosoftGraphSharepointSettings>`: sharepointSettings
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
  - `[IsLoopEnabled <Boolean?>]`: Indicates whetherif Fluid Framework is allowed on SharePoint sites.
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

## RELATED LINKS

