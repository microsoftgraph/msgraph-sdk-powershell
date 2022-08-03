---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementauditevent
schema: 2.0.0
---

# New-MgDeviceManagementAuditEvent

## SYNOPSIS
Create new navigation property to auditEvents for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementAuditEvent [-Activity <String>] [-ActivityDateTime <DateTime>]
 [-ActivityOperationType <String>] [-ActivityResult <String>] [-ActivityType <String>]
 [-Actor <IMicrosoftGraphAuditActor>] [-AdditionalProperties <Hashtable>] [-Category <String>]
 [-ComponentName <String>] [-CorrelationId <String>] [-DisplayName <String>] [-Id <String>]
 [-Resources <IMicrosoftGraphAuditResource[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementAuditEvent -BodyParameter <IMicrosoftGraphAuditEvent> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to auditEvents for deviceManagement

## EXAMPLES

## PARAMETERS

### -Activity
Friendly name of the activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityDateTime
The date time in UTC when the activity was performed.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityOperationType
The HTTP operation type of the activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityResult
The result of the activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityType
The type of activity that was being performed.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Actor
A class containing the properties for Audit Actor.
To construct, please use Get-Help -Online and see NOTES section for ACTOR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditActor
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
A class containing the properties for Audit Event.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditEvent
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
Audit category.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComponentName
Component name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CorrelationId
The client request Id that is used to correlate activity within the system.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Event display name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Resources
Resources being modified.
To construct, please use Get-Help -Online and see NOTES section for RESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditResource[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditEvent

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditEvent

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTOR <IMicrosoftGraphAuditActor>: A class containing the properties for Audit Actor.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApplicationDisplayName <String>]`: Name of the Application.
  - `[ApplicationId <String>]`: AAD Application Id.
  - `[IPAddress <String>]`: IPAddress.
  - `[RemoteTenantId <String>]`: Remote Tenant Id
  - `[RemoteUserId <String>]`: Remote User Id
  - `[ServicePrincipalName <String>]`: Service Principal Name (SPN).
  - `[Type <String>]`: Actor Type.
  - `[UserId <String>]`: User Id.
  - `[UserPermissions <String[]>]`: List of user permissions when the audit was performed.
  - `[UserPrincipalName <String>]`: User Principal Name (UPN).
  - `[UserRoleScopeTags <IMicrosoftGraphRoleScopeTagInfo[]>]`: List of user scope tags when the audit was performed.
    - `[DisplayName <String>]`: Scope Tag Display name.
    - `[RoleScopeTagId <String>]`: Scope Tag Id.

BODYPARAMETER <IMicrosoftGraphAuditEvent>: A class containing the properties for Audit Event.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Activity <String>]`: Friendly name of the activity.
  - `[ActivityDateTime <DateTime?>]`: The date time in UTC when the activity was performed.
  - `[ActivityOperationType <String>]`: The HTTP operation type of the activity.
  - `[ActivityResult <String>]`: The result of the activity.
  - `[ActivityType <String>]`: The type of activity that was being performed.
  - `[Actor <IMicrosoftGraphAuditActor>]`: A class containing the properties for Audit Actor.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationDisplayName <String>]`: Name of the Application.
    - `[ApplicationId <String>]`: AAD Application Id.
    - `[IPAddress <String>]`: IPAddress.
    - `[RemoteTenantId <String>]`: Remote Tenant Id
    - `[RemoteUserId <String>]`: Remote User Id
    - `[ServicePrincipalName <String>]`: Service Principal Name (SPN).
    - `[Type <String>]`: Actor Type.
    - `[UserId <String>]`: User Id.
    - `[UserPermissions <String[]>]`: List of user permissions when the audit was performed.
    - `[UserPrincipalName <String>]`: User Principal Name (UPN).
    - `[UserRoleScopeTags <IMicrosoftGraphRoleScopeTagInfo[]>]`: List of user scope tags when the audit was performed.
      - `[DisplayName <String>]`: Scope Tag Display name.
      - `[RoleScopeTagId <String>]`: Scope Tag Id.
  - `[Category <String>]`: Audit category.
  - `[ComponentName <String>]`: Component name.
  - `[CorrelationId <String>]`: The client request Id that is used to correlate activity within the system.
  - `[DisplayName <String>]`: Event display name.
  - `[Resources <IMicrosoftGraphAuditResource[]>]`: Resources being modified.
    - `[DisplayName <String>]`: Display name.
    - `[ModifiedProperties <IMicrosoftGraphAuditProperty[]>]`: List of modified properties.
      - `[DisplayName <String>]`: Display name.
      - `[NewValue <String>]`: New value.
      - `[OldValue <String>]`: Old value.
    - `[ResourceId <String>]`: Audit resource's Id.
    - `[Type <String>]`: Audit resource's type.

RESOURCES <IMicrosoftGraphAuditResource[]>: Resources being modified.
  - `[DisplayName <String>]`: Display name.
  - `[ModifiedProperties <IMicrosoftGraphAuditProperty[]>]`: List of modified properties.
    - `[DisplayName <String>]`: Display name.
    - `[NewValue <String>]`: New value.
    - `[OldValue <String>]`: Old value.
  - `[ResourceId <String>]`: Audit resource's Id.
  - `[Type <String>]`: Audit resource's type.

## RELATED LINKS

