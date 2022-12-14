---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.managedtenants/new-mgtenantrelationshipmanagedtenantcloudpcconnection
schema: 2.0.0
---

# New-MgBetaTenantRelationshipManagedTenantCloudPcConnection

## SYNOPSIS
Create new navigation property to cloudPcConnections for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipManagedTenantCloudPcConnection [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-HealthCheckStatus <String>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-TenantDisplayName <String>] [-TenantId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipManagedTenantCloudPcConnection
 -BodyParameter <IMicrosoftGraphManagedTenantsCloudPcConnection> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to cloudPcConnections for tenantRelationships

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
cloudPcConnection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcConnection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name of the cloud PC connection.
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

### -HealthCheckStatus
The health status of the cloud PC connection.
Possible values are: pending, running, passed, failed, unknownFutureValue.
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

### -LastRefreshedDateTime
Date and time the entity was last updated in the multi-tenant management platform.
Required.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcConnection

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcConnection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsCloudPcConnection>: cloudPcConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the cloud PC connection. Required. Read-only.
  - `[HealthCheckStatus <String>]`: The health status of the cloud PC connection. Possible values are: pending, running, passed, failed, unknownFutureValue.  Required. Read-only.
  - `[LastRefreshedDateTime <DateTime?>]`: Date and time the entity was last updated in the multi-tenant management platform. Required. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Required. Read-only.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.

## RELATED LINKS

