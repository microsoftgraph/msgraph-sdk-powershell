---
external help file:
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/update-mguserdrivelistsubscription
schema: 2.0.0
---

# Update-MgUserDriveListSubscription

## SYNOPSIS
Update the navigation property subscriptions in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserDriveListSubscription -DriveId <String> -SubscriptionId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ApplicationId <String>] [-ChangeType <String>] [-ClientState <String>]
 [-CreatorId <String>] [-EncryptionCertificate <String>] [-EncryptionCertificateId <String>]
 [-ExpirationDateTime <DateTime>] [-Id <String>] [-IncludeResourceData] [-LatestSupportedTlsVersion <String>]
 [-LifecycleNotificationUrl <String>] [-NotificationContentType <String>] [-NotificationQueryOptions <String>]
 [-NotificationUrl <String>] [-NotificationUrlAppId <String>] [-Resource <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgUserDriveListSubscription -DriveId <String> -SubscriptionId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphSubscription1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserDriveListSubscription -InputObject <IFilesIdentity> -BodyParameter <IMicrosoftGraphSubscription1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserDriveListSubscription -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-ApplicationId <String>] [-ChangeType <String>] [-ClientState <String>] [-CreatorId <String>]
 [-EncryptionCertificate <String>] [-EncryptionCertificateId <String>] [-ExpirationDateTime <DateTime>]
 [-Id <String>] [-IncludeResourceData] [-LatestSupportedTlsVersion <String>]
 [-LifecycleNotificationUrl <String>] [-NotificationContentType <String>] [-NotificationQueryOptions <String>]
 [-NotificationUrl <String>] [-NotificationUrlAppId <String>] [-Resource <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property subscriptions in users

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

### -ApplicationId
Optional.
Identifier of the application used to create the subscription.
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

### -BodyParameter
subscription
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscription1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChangeType
Required.
Indicates the type of change in the subscribed resource that will raise a change notification.
The supported values are: created, updated, deleted.
Multiple values can be combined using a comma-separated list.
Note: Drive root item and list change notifications support only the updated changeType.
User and group change notifications support updated and deleted changeType.

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

### -ClientState
Optional.
Specifies the value of the clientState property sent by the service in each change notification.
The maximum length is 255 characters.
The client can check that the change notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each change notification.

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

### -CreatorId
Optional.
Identifier of the user or service principal that created the subscription.
If the app used delegated permissions to create the subscription, this field contains the ID of the signed-in user the app called on behalf of.
If the app used application permissions, this field contains the ID of the service principal corresponding to the app.
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

### -DriveId
key: id of drive

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

### -EncryptionCertificate
Optional.
A base64-encoded representation of a certificate with a public key used to encrypt resource data in change notifications.
Optional but required when includeResourceData is true.

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

### -EncryptionCertificateId
Optional.
A custom app-provided identifier to help identify the certificate needed to decrypt resource data.
Required when includeResourceData is true.

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

### -ExpirationDateTime
Required.
Specifies the date and time when the webhook subscription expires.
The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to.
For the maximum supported subscription length of time, see the table below.

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

### -IncludeResourceData
Optional.
When set to true, change notifications include resource data (such as content of a chat message).

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

### -LatestSupportedTlsVersion
Optional.
Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports.
The possible values are: v1_0, v1_1, v1_2, v1_3.
For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2.
For these subscribers, not setting this property per the timeline would result in subscription operations failing.
For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional.
In such cases, Microsoft Graph defaults the property to v1_2.

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

### -LifecycleNotificationUrl
Optional.
The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved and missed notifications.
This URL must make use of the HTTPS protocol.

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

### -NotificationContentType
Optional.
Desired content-type for Microsoft Graph change notifications for supported resource types.
The default content-type is application/json.

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

### -NotificationQueryOptions
Optional.
OData query options for specifying the value for the targeting resource.
Clients receive notifications when the resource reaches the state matching the query options provided here.
With this new property in the subscription creation payload along with all existing properties, Webhooks will deliver notifications whenever a resource reaches the desired state mentioned in the notificationQueryOptions property.
For example, when the print job is completed or when a print job resource isFetchable property value becomes true etc.

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

### -NotificationUrl
Required.
The URL of the endpoint that receives the change notifications.
This URL must make use of the HTTPS protocol.

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

### -NotificationUrlAppId
Optional.
The app ID that the subscription service can use to generate the validation token.
This allows the client to validate the authenticity of the notification received.

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
Do not include the base URL (https://graph.microsoft.com/beta/).
See the possible resource path values for each supported resource.

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

### -SubscriptionId
key: id of subscription

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

### -UserId
key: id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscription1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSubscription1>: subscription
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ApplicationId <String>]`: Optional. Identifier of the application used to create the subscription. Read-only.
  - `[ChangeType <String>]`: Required. Indicates the type of change in the subscribed resource that will raise a change notification. The supported values are: created, updated, deleted. Multiple values can be combined using a comma-separated list. Note:  Drive root item and list change notifications support only the updated changeType. User and group change notifications support updated and deleted changeType.
  - `[ClientState <String>]`: Optional. Specifies the value of the clientState property sent by the service in each change notification. The maximum length is 255 characters. The client can check that the change notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each change notification.
  - `[CreatorId <String>]`: Optional. Identifier of the user or service principal that created the subscription. If the app used delegated permissions to create the subscription, this field contains the ID of the signed-in user the app called on behalf of. If the app used application permissions, this field contains the ID of the service principal corresponding to the app. Read-only.
  - `[EncryptionCertificate <String>]`: Optional. A base64-encoded representation of a certificate with a public key used to encrypt resource data in change notifications. Optional but required when includeResourceData is true.
  - `[EncryptionCertificateId <String>]`: Optional. A custom app-provided identifier to help identify the certificate needed to decrypt resource data. Required when includeResourceData is true.
  - `[ExpirationDateTime <DateTime?>]`: Required. Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to. For the maximum supported subscription length of time, see the table below.
  - `[IncludeResourceData <Boolean?>]`: Optional. When set to true, change notifications include resource data (such as content of a chat message).
  - `[LatestSupportedTlsVersion <String>]`: Optional. Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports. The possible values are: v1_0, v1_1, v1_2, v1_3. For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2. For these subscribers, not setting this property per the timeline would result in subscription operations failing. For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional. In such cases, Microsoft Graph defaults the property to v1_2.
  - `[LifecycleNotificationUrl <String>]`: Optional. The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved and missed notifications. This URL must make use of the HTTPS protocol.
  - `[NotificationContentType <String>]`: Optional. Desired content-type for Microsoft Graph change notifications for supported resource types. The default content-type is application/json.
  - `[NotificationQueryOptions <String>]`: Optional.  OData query options for specifying the value for the targeting resource. Clients receive notifications when the resource reaches the state matching the query options provided here. With this new property in the subscription creation payload along with all existing properties, Webhooks will deliver notifications whenever a resource reaches the desired state mentioned in the notificationQueryOptions property. For example, when the print job is completed or when a print job resource isFetchable property value becomes true etc.
  - `[NotificationUrl <String>]`: Required. The URL of the endpoint that receives the change notifications. This URL must make use of the HTTPS protocol.
  - `[NotificationUrlAppId <String>]`: Optional. The app ID that the subscription service can use to generate the validation token. This allows the client to validate the authenticity of the notification received.
  - `[Resource <String>]`: Required. Specifies the resource that will be monitored for changes. Do not include the base URL (https://graph.microsoft.com/beta/). See the possible resource path values for each supported resource.

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

## RELATED LINKS

