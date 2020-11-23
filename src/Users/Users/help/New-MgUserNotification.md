---
external help file: Microsoft.Graph.Users-help.xml
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/new-mgusernotification
schema: 2.0.0
---

# New-MgUserNotification

## SYNOPSIS
Create new navigation property to notifications for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserNotification -UserId <String> [-AdditionalProperties <Hashtable>] [-DisplayTimeToLive <Int32>]
 [-ExpirationDateTime <DateTime>] [-GroupName <String>] [-Id <String>] [-Payload <IMicrosoftGraphPayloadTypes>]
 [-Priority <String>] [-TargetHostName <String>] [-TargetPolicy <IMicrosoftGraphTargetPolicyEndpoints>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgUserNotification -UserId <String> -BodyParameter <IMicrosoftGraphNotification> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserNotification -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>]
 [-DisplayTimeToLive <Int32>] [-ExpirationDateTime <DateTime>] [-GroupName <String>] [-Id <String>]
 [-Payload <IMicrosoftGraphPayloadTypes>] [-Priority <String>] [-TargetHostName <String>]
 [-TargetPolicy <IMicrosoftGraphTargetPolicyEndpoints>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserNotification -InputObject <IUsersIdentity> -BodyParameter <IMicrosoftGraphNotification> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to notifications for users

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
notification
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphNotification
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayTimeToLive
.

```yaml
Type: Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: IUsersIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Payload
payloadTypes
To construct, see NOTES section for PAYLOAD properties and create a hash table.

```yaml
Type: IMicrosoftGraphPayloadTypes
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
priority

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetPolicy
targetPolicyEndpoints
To construct, see NOTES section for TARGETPOLICY properties and create a hash table.

```yaml
Type: IMicrosoftGraphTargetPolicyEndpoints
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotification
### Microsoft.Graph.PowerShell.Models.IUsersIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotification
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphNotification\>: notification
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DisplayTimeToLive \<Int32?\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[GroupName \<String\>\]: 
  \[Payload \<IMicrosoftGraphPayloadTypes\>\]: payloadTypes
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[RawContent \<String\>\]: 
    \[VisualContent \<IMicrosoftGraphVisualProperties\>\]: visualProperties
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Body \<String\>\]: 
      \[Title \<String\>\]: 
  \[Priority \<String\>\]: priority
  \[TargetHostName \<String\>\]: 
  \[TargetPolicy \<IMicrosoftGraphTargetPolicyEndpoints\>\]: targetPolicyEndpoints
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[PlatformTypes \<String\[\]\>\]: 

INPUTOBJECT \<IUsersIdentity\>: Identity Parameter
  \[AttachmentId \<String\>\]: key: id of attachment
  \[ExtensionId \<String\>\]: key: id of extension
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[LinkedResourceId \<String\>\]: key: id of linkedResource
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[NotificationId \<String\>\]: key: id of notification
  \[OutlookCategoryId \<String\>\]: key: id of outlookCategory
  \[OutlookTaskFolderId \<String\>\]: key: id of outlookTaskFolder
  \[OutlookTaskGroupId \<String\>\]: key: id of outlookTaskGroup
  \[OutlookTaskId \<String\>\]: key: id of outlookTask
  \[ProfilePhotoId \<String\>\]: key: id of profilePhoto
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[TodoTaskId \<String\>\]: key: id of todoTask
  \[TodoTaskListId \<String\>\]: key: id of todoTaskList
  \[UserId \<String\>\]: key: id of user

PAYLOAD \<IMicrosoftGraphPayloadTypes\>: payloadTypes
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[RawContent \<String\>\]: 
  \[VisualContent \<IMicrosoftGraphVisualProperties\>\]: visualProperties
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Body \<String\>\]: 
    \[Title \<String\>\]: 

TARGETPOLICY \<IMicrosoftGraphTargetPolicyEndpoints\>: targetPolicyEndpoints
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[PlatformTypes \<String\[\]\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/new-mgusernotification](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/new-mgusernotification)

