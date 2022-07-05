---
external help file:
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/update-mgsharepermission
schema: 2.0.0
---

# Update-MgSharePermission

## SYNOPSIS
Update the navigation property permission in shares

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgSharePermission -SharedDriveItemId <String> [-AdditionalProperties <Hashtable>]
 [-ExpirationDateTime <DateTime>] [-GrantedTo <IMicrosoftGraphIdentitySet>]
 [-GrantedToIdentities <IMicrosoftGraphIdentitySet[]>]
 [-GrantedToIdentitiesV2 <IMicrosoftGraphSharePointIdentitySet[]>]
 [-GrantedToV2 <IMicrosoftGraphSharePointIdentitySet>] [-HasPassword] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-Invitation <IMicrosoftGraphSharingInvitation>]
 [-Link <IMicrosoftGraphSharingLink1>] [-Roles <String[]>] [-ShareId <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgSharePermission -SharedDriveItemId <String> -BodyParameter <IMicrosoftGraphPermission1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgSharePermission -InputObject <IFilesIdentity> -BodyParameter <IMicrosoftGraphPermission1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgSharePermission -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-ExpirationDateTime <DateTime>] [-GrantedTo <IMicrosoftGraphIdentitySet>]
 [-GrantedToIdentities <IMicrosoftGraphIdentitySet[]>]
 [-GrantedToIdentitiesV2 <IMicrosoftGraphSharePointIdentitySet[]>]
 [-GrantedToV2 <IMicrosoftGraphSharePointIdentitySet>] [-HasPassword] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-Invitation <IMicrosoftGraphSharingInvitation>]
 [-Link <IMicrosoftGraphSharingLink1>] [-Roles <String[]>] [-ShareId <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property permission in shares

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
permission
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermission1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExpirationDateTime
A format of yyyy-MM-ddTHH:mm:ssZ of DateTimeOffset indicates the expiration time of the permission.
DateTime.MinValue indicates there is no expiration set for this permission.
Optional.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantedTo
identitySet
To construct, please use Get-Help -Online and see NOTES section for GRANTEDTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantedToIdentities
.
To construct, please use Get-Help -Online and see NOTES section for GRANTEDTOIDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantedToIdentitiesV2
For link type permissions, the details of the users to whom permission was granted.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for GRANTEDTOIDENTITIESV2 properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharePointIdentitySet[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantedToV2
sharePointIdentitySet
To construct, please use Get-Help -Online and see NOTES section for GRANTEDTOV2 properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharePointIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasPassword
Indicates whether the password is set for this permission.
This property only appears in the response.
Optional.
Read-only.
For OneDrive Personal only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InheritedFrom
itemReference
To construct, please use Get-Help -Online and see NOTES section for INHERITEDFROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemReference
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IFilesIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Invitation
sharingInvitation
To construct, please use Get-Help -Online and see NOTES section for INVITATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharingInvitation
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Link
sharingLink
To construct, please use Get-Help -Online and see NOTES section for LINK properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharingLink1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
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

### -Roles
The type of permission, for example, read.
See below for the full list of roles.
Read-only.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedDriveItemId
key: id of sharedDriveItem

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShareId
A unique token that can be used to access this shared item via the [shares API][].
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IFilesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermission1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPermission1>: permission
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ExpirationDateTime <DateTime?>]`: A format of yyyy-MM-ddTHH:mm:ssZ of DateTimeOffset indicates the expiration time of the permission. DateTime.MinValue indicates there is no expiration set for this permission. Optional.
  - `[GrantedTo <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[GrantedToIdentities <IMicrosoftGraphIdentitySet[]>]`: 
  - `[GrantedToIdentitiesV2 <IMicrosoftGraphSharePointIdentitySet[]>]`: For link type permissions, the details of the users to whom permission was granted. Read-only.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Group <IMicrosoftGraphIdentity>]`: identity
    - `[SiteGroup <IMicrosoftGraphSharePointIdentity>]`: sharePointIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
      - `[LoginName <String>]`: The sign in name of the SharePoint identity.
    - `[SiteUser <IMicrosoftGraphSharePointIdentity>]`: sharePointIdentity
  - `[GrantedToV2 <IMicrosoftGraphSharePointIdentitySet>]`: sharePointIdentitySet
  - `[HasPassword <Boolean?>]`: Indicates whether the password is set for this permission. This property only appears in the response. Optional. Read-only. For OneDrive Personal only.
  - `[InheritedFrom <IMicrosoftGraphItemReference>]`: itemReference
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
    - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
    - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
    - `[Name <String>]`: The name of the item being referenced. Read-only.
    - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
    - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
    - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
      - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
      - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
      - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
      - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
      - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
      - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
    - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.
  - `[Invitation <IMicrosoftGraphSharingInvitation>]`: sharingInvitation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Email <String>]`: The email address provided for the recipient of the sharing invitation. Read-only.
    - `[InvitedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RedeemedBy <String>]`: 
    - `[SignInRequired <Boolean?>]`: If true the recipient of the invitation needs to sign in in order to access the shared item. Read-only.
  - `[Link <IMicrosoftGraphSharingLink1>]`: sharingLink
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[ConfiguratorUrl <String>]`: 
    - `[PreventsDownload <Boolean?>]`: If true then the user can only use this link to view the item on the web, and cannot use it to download the contents of the item. Only for OneDrive for Business and SharePoint.
    - `[Scope <String>]`: The scope of the link represented by this permission. Value anonymous indicates the link is usable by anyone, organization indicates the link is only usable for users signed into the same tenant.
    - `[Type <String>]`: The type of the link created.
    - `[WebHtml <String>]`: For embed links, this property contains the HTML code for an <iframe> element that will embed the item in a webpage.
    - `[WebUrl <String>]`: A URL that opens the item in the browser on the OneDrive website.
  - `[Roles <String[]>]`: The type of permission, for example, read. See below for the full list of roles. Read-only.
  - `[ShareId <String>]`: A unique token that can be used to access this shared item via the [shares API][]. Read-only.

GRANTEDTO <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

GRANTEDTOIDENTITIES <IMicrosoftGraphIdentitySet[]>: .
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

GRANTEDTOIDENTITIESV2 <IMicrosoftGraphSharePointIdentitySet[]>: For link type permissions, the details of the users to whom permission was granted. Read-only.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Group <IMicrosoftGraphIdentity>]`: identity
  - `[SiteGroup <IMicrosoftGraphSharePointIdentity>]`: sharePointIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[LoginName <String>]`: The sign in name of the SharePoint identity.
  - `[SiteUser <IMicrosoftGraphSharePointIdentity>]`: sharePointIdentity

GRANTEDTOV2 <IMicrosoftGraphSharePointIdentitySet>: sharePointIdentitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Group <IMicrosoftGraphIdentity>]`: identity
  - `[SiteGroup <IMicrosoftGraphSharePointIdentity>]`: sharePointIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[LoginName <String>]`: The sign in name of the SharePoint identity.
  - `[SiteUser <IMicrosoftGraphSharePointIdentity>]`: sharePointIdentity

INHERITEDFROM <IMicrosoftGraphItemReference>: itemReference
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
  - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
  - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
  - `[Name <String>]`: The name of the item being referenced. Read-only.
  - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
  - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
  - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
    - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
    - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
    - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
    - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
    - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
    - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
  - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.

INPUTOBJECT <IFilesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: id of columnDefinition
  - `[ColumnLinkId <String>]`: key: id of columnLink
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[ContentTypeId1 <String>]`: key: id of contentType
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[DriveItemId1 <String>]`: key: id of driveItem
  - `[DriveItemVersionId <String>]`: key: id of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: key: id of group
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[PermissionId <String>]`: key: id of permission
  - `[Q <String>]`: Usage: q='{q}'
  - `[RichLongRunningOperationId <String>]`: key: id of richLongRunningOperation
  - `[SharedDriveItemId <String>]`: key: id of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[ThumbnailSetId <String>]`: key: id of thumbnailSet
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: key: id of user

INVITATION <IMicrosoftGraphSharingInvitation>: sharingInvitation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Email <String>]`: The email address provided for the recipient of the sharing invitation. Read-only.
  - `[InvitedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[RedeemedBy <String>]`: 
  - `[SignInRequired <Boolean?>]`: If true the recipient of the invitation needs to sign in in order to access the shared item. Read-only.

LINK <IMicrosoftGraphSharingLink1>: sharingLink
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[ConfiguratorUrl <String>]`: 
  - `[PreventsDownload <Boolean?>]`: If true then the user can only use this link to view the item on the web, and cannot use it to download the contents of the item. Only for OneDrive for Business and SharePoint.
  - `[Scope <String>]`: The scope of the link represented by this permission. Value anonymous indicates the link is usable by anyone, organization indicates the link is only usable for users signed into the same tenant.
  - `[Type <String>]`: The type of the link created.
  - `[WebHtml <String>]`: For embed links, this property contains the HTML code for an <iframe> element that will embed the item in a webpage.
  - `[WebUrl <String>]`: A URL that opens the item in the browser on the OneDrive website.

## RELATED LINKS

