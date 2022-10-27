---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenantdevicecompliancepolicysettingstatesummary
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantDeviceCompliancePolicySettingStateSummary

## SYNOPSIS
Create new navigation property to deviceCompliancePolicySettingStateSummaries for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantDeviceCompliancePolicySettingStateSummary
 [-AdditionalProperties <Hashtable>] [-ConflictDeviceCount <Int32>] [-ErrorDeviceCount <Int32>]
 [-FailedDeviceCount <Int32>] [-Id <String>] [-IntuneAccountId <String>] [-IntuneSettingId <String>]
 [-LastRefreshedDateTime <DateTime>] [-NotApplicableDeviceCount <Int32>] [-PendingDeviceCount <Int32>]
 [-PolicyType <String>] [-SettingName <String>] [-SucceededDeviceCount <Int32>] [-TenantDisplayName <String>]
 [-TenantId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantDeviceCompliancePolicySettingStateSummary
 -BodyParameter <IMicrosoftGraphManagedTenantsDeviceCompliancePolicySettingStateSummary> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceCompliancePolicySettingStateSummaries for tenantRelationships

## EXAMPLES

## PARAMETERS

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
deviceCompliancePolicySettingStateSummary
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsDeviceCompliancePolicySettingStateSummary
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConflictDeviceCount
The number of devices in a conflict state.
Optional.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ErrorDeviceCount
The number of devices in an error state.
Optional.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FailedDeviceCount
The number of devices in a failed state.
Optional.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IntuneAccountId
The identifer for the Microsoft Intune account.
Required.
Read-only.

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

### -IntuneSettingId
The identifier for the Intune setting.
Optional.
Read-only.

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

### -LastRefreshedDateTime
Date and time the entity was last updated in the multi-tenant management platform.
Optional.
Read-only.

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

### -NotApplicableDeviceCount
The number of devices in a not applicable state.
Optional.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PendingDeviceCount
The number of devices in a pending state.
Optional.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyType
The type for the device compliance policy.
Optional.
Read-only.

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

### -SettingName
The name for the setting within the device compliance policy.
Optional.
Read-only.

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

### -SucceededDeviceCount
The number of devices in a succeeded state.
Optional.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantDisplayName
The display name for the managed tenant.
Required.
Read-only.

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

### -TenantId
The Azure Active Directory tenant identifier for the managed tenant.
Required.
Read-only.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsDeviceCompliancePolicySettingStateSummary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsDeviceCompliancePolicySettingStateSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsDeviceCompliancePolicySettingStateSummary>: deviceCompliancePolicySettingStateSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConflictDeviceCount <Int32?>]`: The number of devices in a conflict state. Optional. Read-only.
  - `[ErrorDeviceCount <Int32?>]`: The number of devices in an error state. Optional. Read-only.
  - `[FailedDeviceCount <Int32?>]`: The number of devices in a failed state. Optional. Read-only.
  - `[IntuneAccountId <String>]`: The identifer for the Microsoft Intune account. Required. Read-only.
  - `[IntuneSettingId <String>]`: The identifier for the Intune setting. Optional. Read-only.
  - `[LastRefreshedDateTime <DateTime?>]`: Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.
  - `[NotApplicableDeviceCount <Int32?>]`: The number of devices in a not applicable state. Optional. Read-only.
  - `[PendingDeviceCount <Int32?>]`: The number of devices in a pending state. Optional. Read-only.
  - `[PolicyType <String>]`: The type for the device compliance policy. Optional. Read-only.
  - `[SettingName <String>]`: The name for the setting within the device compliance policy. Optional. Read-only.
  - `[SucceededDeviceCount <Int32?>]`: The number of devices in a succeeded state. Optional. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Required. Read-only.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.

## RELATED LINKS

