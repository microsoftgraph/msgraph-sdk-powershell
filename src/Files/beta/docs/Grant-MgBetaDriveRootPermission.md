---
external help file:
Module Name: Microsoft.Graph.Beta.Files
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.files/grant-mgbetadriverootpermission
schema: 2.0.0
---

# Grant-MgBetaDriveRootPermission

## SYNOPSIS
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

## SYNTAX

### GrantExpanded (Default)
```
Grant-MgBetaDriveRootPermission -DriveId <String> -PermissionId <String> [-AdditionalProperties <Hashtable>]
 [-Recipients <IMicrosoftGraphDriveRecipient[]>] [-Roles <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Grant
```
Grant-MgBetaDriveRootPermission -DriveId <String> -PermissionId <String>
 -BodyParameter <IPaths1P92961DrivesDriveIdRootPermissionsPermissionIdMicrosoftGraphGrantPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GrantViaIdentity
```
Grant-MgBetaDriveRootPermission -InputObject <IFilesIdentity>
 -BodyParameter <IPaths1P92961DrivesDriveIdRootPermissionsPermissionIdMicrosoftGraphGrantPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GrantViaIdentityExpanded
```
Grant-MgBetaDriveRootPermission -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-Recipients <IMicrosoftGraphDriveRecipient[]>] [-Roles <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

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
Parameter Sets: GrantExpanded, GrantViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1P92961DrivesDriveIdRootPermissionsPermissionIdMicrosoftGraphGrantPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Grant, GrantViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DriveId
The unique identifier of drive

```yaml
Type: System.String
Parameter Sets: Grant, GrantExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IFilesIdentity
Parameter Sets: GrantViaIdentity, GrantViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PermissionId
The unique identifier of permission

```yaml
Type: System.String
Parameter Sets: Grant, GrantExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Recipients
.
To construct, see NOTES section for RECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDriveRecipient[]
Parameter Sets: GrantExpanded, GrantViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Roles
.

```yaml
Type: System.String[]
Parameter Sets: GrantExpanded, GrantViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IFilesIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1P92961DrivesDriveIdRootPermissionsPermissionIdMicrosoftGraphGrantPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermission

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1P92961DrivesDriveIdRootPermissionsPermissionIdMicrosoftGraphGrantPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Recipients <IMicrosoftGraphDriveRecipient[]>]`: 
    - `[Alias <String>]`: The alias of the domain object, for cases where an email address is unavailable (e.g. security groups).
    - `[Email <String>]`: The email address for the recipient, if the recipient has an associated email address.
    - `[ObjectId <String>]`: The unique identifier for the recipient in the directory.
  - `[Roles <String[]>]`: 

`INPUTOBJECT <IFilesIdentity>`: Identity Parameter
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemId1 <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[Q <String>]`: Usage: q='{q}'
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SharedDriveItemId <String>]`: The unique identifier of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[ThumbnailSetId <String>]`: The unique identifier of thumbnailSet
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user

`RECIPIENTS <IMicrosoftGraphDriveRecipient[]>`: .
  - `[Alias <String>]`: The alias of the domain object, for cases where an email address is unavailable (e.g. security groups).
  - `[Email <String>]`: The email address for the recipient, if the recipient has an associated email address.
  - `[ObjectId <String>]`: The unique identifier for the recipient in the directory.

## RELATED LINKS

