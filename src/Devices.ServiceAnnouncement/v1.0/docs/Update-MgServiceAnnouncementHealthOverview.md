---
external help file:
Module Name: Microsoft.Graph.Devices.ServiceAnnouncement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.serviceannouncement/update-mgserviceannouncementhealthoverview
schema: 2.0.0
---

# Update-MgServiceAnnouncementHealthOverview

## SYNOPSIS
Update the navigation property healthOverviews in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgServiceAnnouncementHealthOverview -ServiceHealthId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-Issues <IMicrosoftGraphServiceHealthIssue[]>] [-Service <String>] [-Status <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgServiceAnnouncementHealthOverview -ServiceHealthId <String>
 -BodyParameter <IMicrosoftGraphServiceHealth> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgServiceAnnouncementHealthOverview -InputObject <IDevicesServiceAnnouncementIdentity>
 -BodyParameter <IMicrosoftGraphServiceHealth> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgServiceAnnouncementHealthOverview -InputObject <IDevicesServiceAnnouncementIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Issues <IMicrosoftGraphServiceHealthIssue[]>]
 [-Service <String>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property healthOverviews in admin

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
serviceHealth
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceHealth
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesServiceAnnouncementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Issues
A collection of issues that happened on the service, with detailed information for each issue.
To construct, see NOTES section for ISSUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceHealthIssue[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Service
The service name.
Use the list healthOverviews operation to get exact string names for services subscribed by the tenant.

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

### -ServiceHealthId
The unique identifier of serviceHealth

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

### -Status
serviceHealthStatus

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

### Microsoft.Graph.PowerShell.Models.IDevicesServiceAnnouncementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceHealth

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceHealth

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphServiceHealth>`: serviceHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Issues <IMicrosoftGraphServiceHealthIssue[]>]`: A collection of issues that happened on the service, with detailed information for each issue.
    - `[Details <IMicrosoftGraphKeyValuePair[]>]`: More details about service event. This property doesn't support filters.
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[EndDateTime <DateTime?>]`: The end time of the service event.
    - `[LastModifiedDateTime <DateTime?>]`: The last modified time of the service event.
    - `[StartDateTime <DateTime?>]`: The start time of the service event.
    - `[Title <String>]`: The title of the service event.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Classification <String>]`: serviceHealthClassificationType
    - `[Feature <String>]`: The feature name of the service issue.
    - `[FeatureGroup <String>]`: The feature group name of the service issue.
    - `[ImpactDescription <String>]`: The description of the service issue impact.
    - `[IsResolved <Boolean?>]`: Indicates whether the issue is resolved.
    - `[Origin <String>]`: serviceHealthOrigin
    - `[Posts <IMicrosoftGraphServiceHealthIssuePost[]>]`: Collection of historical posts for the service issue.
      - `[CreatedDateTime <DateTime?>]`: The published time of the post.
      - `[Description <IMicrosoftGraphItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
      - `[PostType <String>]`: postType
    - `[Service <String>]`: Indicates the service affected by the issue.
    - `[Status <String>]`: serviceHealthStatus
  - `[Service <String>]`: The service name. Use the list healthOverviews operation to get exact string names for services subscribed by the tenant.
  - `[Status <String>]`: serviceHealthStatus

`INPUTOBJECT <IDevicesServiceAnnouncementIdentity>`: Identity Parameter
  - `[ServiceAnnouncementAttachmentId <String>]`: The unique identifier of serviceAnnouncementAttachment
  - `[ServiceHealthId <String>]`: The unique identifier of serviceHealth
  - `[ServiceHealthIssueId <String>]`: The unique identifier of serviceHealthIssue
  - `[ServiceUpdateMessageId <String>]`: The unique identifier of serviceUpdateMessage

`ISSUES <IMicrosoftGraphServiceHealthIssue[]>`: A collection of issues that happened on the service, with detailed information for each issue.
  - `[Details <IMicrosoftGraphKeyValuePair[]>]`: More details about service event. This property doesn't support filters.
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[EndDateTime <DateTime?>]`: The end time of the service event.
  - `[LastModifiedDateTime <DateTime?>]`: The last modified time of the service event.
  - `[StartDateTime <DateTime?>]`: The start time of the service event.
  - `[Title <String>]`: The title of the service event.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Classification <String>]`: serviceHealthClassificationType
  - `[Feature <String>]`: The feature name of the service issue.
  - `[FeatureGroup <String>]`: The feature group name of the service issue.
  - `[ImpactDescription <String>]`: The description of the service issue impact.
  - `[IsResolved <Boolean?>]`: Indicates whether the issue is resolved.
  - `[Origin <String>]`: serviceHealthOrigin
  - `[Posts <IMicrosoftGraphServiceHealthIssuePost[]>]`: Collection of historical posts for the service issue.
    - `[CreatedDateTime <DateTime?>]`: The published time of the post.
    - `[Description <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[PostType <String>]`: postType
  - `[Service <String>]`: Indicates the service affected by the issue.
  - `[Status <String>]`: serviceHealthStatus

## RELATED LINKS

