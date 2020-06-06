---
external help file:
Module Name: Microsoft.Graph.Files.Shares
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.shares/update-mgsharelistsubscription
schema: 2.0.0
---

# Update-MgShareListSubscription

## SYNOPSIS
Update the navigation property subscriptions in shares

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgShareListSubscription -SharedDriveItemId <String> -SubscriptionId <String> [-ApplicationId <String>]
 [-ChangeType <String>] [-ClientState <String>] [-CreatorId <String>] [-ExpirationDateTime <DateTime>]
 [-Id <String>] [-LatestSupportedTlsVersion <String>] [-NotificationUrl <String>] [-Resource <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgShareListSubscription -SharedDriveItemId <String> -SubscriptionId <String>
 -BodyParameter <IMicrosoftGraphSubscription> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgShareListSubscription -InputObject <IFilesSharesIdentity>
 -BodyParameter <IMicrosoftGraphSubscription> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgShareListSubscription -InputObject <IFilesSharesIdentity> [-ApplicationId <String>]
 [-ChangeType <String>] [-ClientState <String>] [-CreatorId <String>] [-ExpirationDateTime <DateTime>]
 [-Id <String>] [-LatestSupportedTlsVersion <String>] [-NotificationUrl <String>] [-Resource <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property subscriptions in shares

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ApplicationId
Identifier of the application used to create the subscription.
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

### -BodyParameter
subscription
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscription
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChangeType
Required.
Indicates the type of change in the subscribed resource that will raise a notification.
The supported values are: created, updated, deleted.
Multiple values can be combined using a comma-separated list.Note: Drive root item and list notifications support only the updated changeType.
User and group notifications support updated and deleted changeType.

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

### -ClientState
Optional.
Specifies the value of the clientState property sent by the service in each notification.
The maximum length is 128 characters.
The client can check that the notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each notification.

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

### -CreatorId
Identifier of the user or service principal that created the subscription.
If the app used delegated permissions to create the subscription, this field contains the id of the signed-in user the app called on behalf of.
If the app used application permissions, this field contains the id of the service principal corresponding to the app.
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

### -ExpirationDateTime
Required.
Specifies the date and time when the webhook subscription expires.
The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to.
See the table below for maximum supported subscription length of time.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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
Type: Microsoft.Graph.PowerShell.Models.IFilesSharesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LatestSupportedTlsVersion
Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports.
The possible values are: v1_0, v1_1, v1_2, v1_3.
For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2.
For these subscribers, not setting this property per the timeline would result in subscription operations failing.
For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional.
In such cases, Microsoft Graph defaults the property to v1_2.

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

### -NotificationUrl
Required.
The URL of the endpoint that will receive the notifications.
This URL must make use of the HTTPS protocol.

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

### -Resource
Required.
Specifies the resource that will be monitored for changes.
Do not include the base URL (https://graph.microsoft.com/v1.0/).
See the possible resource path values for each supported resource.

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

### -SharedDriveItemId
key: sharedDriveItem-id of sharedDriveItem

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

### -SubscriptionId
key: subscription-id of subscription

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

### Microsoft.Graph.PowerShell.Models.IFilesSharesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscription

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSubscription>: subscription
  - `[Id <String>]`: Read-only.
  - `[ApplicationId <String>]`: Identifier of the application used to create the subscription. Read-only.
  - `[ChangeType <String>]`: Required. Indicates the type of change in the subscribed resource that will raise a notification. The supported values are: created, updated, deleted. Multiple values can be combined using a comma-separated list.Note: Drive root item and list notifications support only the updated changeType. User and group notifications support updated and deleted changeType.
  - `[ClientState <String>]`: Optional. Specifies the value of the clientState property sent by the service in each notification. The maximum length is 128 characters. The client can check that the notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each notification.
  - `[CreatorId <String>]`: Identifier of the user or service principal that created the subscription. If the app used delegated permissions to create the subscription, this field contains the id of the signed-in user the app called on behalf of. If the app used application permissions, this field contains the id of the service principal corresponding to the app. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: Required. Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to.  See the table below for maximum supported subscription length of time.
  - `[LatestSupportedTlsVersion <String>]`: Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports. The possible values are: v1_0, v1_1, v1_2, v1_3. For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2. For these subscribers, not setting this property per the timeline would result in subscription operations failing. For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional. In such cases, Microsoft Graph defaults the property to v1_2.
  - `[NotificationUrl <String>]`: Required. The URL of the endpoint that will receive the notifications. This URL must make use of the HTTPS protocol.
  - `[Resource <String>]`: Required. Specifies the resource that will be monitored for changes. Do not include the base URL (https://graph.microsoft.com/v1.0/). See the possible resource path values for each supported resource.

INPUTOBJECT <IFilesSharesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[DriveItemId <String>]`: key: driveItem-id of driveItem
  - `[EndDateTime <String>]`: 
  - `[Interval <String>]`: 
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ItemActivityOldId1 <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[SharedDriveItemId <String>]`: key: sharedDriveItem-id of sharedDriveItem
  - `[StartDateTime <String>]`: 
  - `[SubscriptionId <String>]`: key: subscription-id of subscription

## RELATED LINKS

