---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenantcredentialuserregistrationsummary
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantCredentialUserRegistrationSummary

## SYNOPSIS
Create new navigation property to credentialUserRegistrationsSummaries for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantCredentialUserRegistrationSummary [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-LastRefreshedDateTime <DateTime>] [-MfaAndSsprCapableUserCount <Int32>]
 [-MfaConditionalAccessPolicyState <String>] [-MfaExcludedUserCount <Int32>] [-MfaRegisteredUserCount <Int32>]
 [-SecurityDefaultsEnabled] [-SsprEnabledUserCount <Int32>] [-SsprRegisteredUserCount <Int32>]
 [-TenantDisplayName <String>] [-TenantId <String>] [-TotalUserCount <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantCredentialUserRegistrationSummary
 -BodyParameter <IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to credentialUserRegistrationsSummaries for tenantRelationships

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
credentialUserRegistrationsSummary
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -MfaAndSsprCapableUserCount
The number of users that are capable of performing multi-factor authentication or self service password reset.
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

### -MfaConditionalAccessPolicyState
The state of a conditional access policy that enforces multi-factor authentication.
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

### -MfaExcludedUserCount
The number of users in the multi-factor authentication exclusion security group (Microsoft 365 Lighthouse - MFA exclusions).
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

### -MfaRegisteredUserCount
The number of users registered for multi-factor authentication.
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

### -SecurityDefaultsEnabled
A flag indicating whether Identity Security Defaults is enabled.
Optional.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsprEnabledUserCount
The number of users enabled for self service password reset.
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

### -SsprRegisteredUserCount
The number of users registered for self service password reset.
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

### -TotalUserCount
The total number of users in the given managed tenant.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary>: credentialUserRegistrationsSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[LastRefreshedDateTime <DateTime?>]`: Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.
  - `[MfaAndSsprCapableUserCount <Int32?>]`: The number of users that are capable of performing multi-factor authentication or self service password reset. Optional. Read-only.
  - `[MfaConditionalAccessPolicyState <String>]`: The state of a conditional access policy that enforces multi-factor authentication. Optional. Read-only.
  - `[MfaExcludedUserCount <Int32?>]`: The number of users in the multi-factor authentication exclusion security group (Microsoft 365 Lighthouse - MFA exclusions). Optional. Read-only.
  - `[MfaRegisteredUserCount <Int32?>]`: The number of users registered for multi-factor authentication. Optional. Read-only.
  - `[SecurityDefaultsEnabled <Boolean?>]`: A flag indicating whether Identity Security Defaults is enabled. Optional. Read-only.
  - `[SsprEnabledUserCount <Int32?>]`: The number of users enabled for self service password reset. Optional. Read-only.
  - `[SsprRegisteredUserCount <Int32?>]`: The number of users registered for self service password reset. Optional. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Required. Read-only.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.
  - `[TotalUserCount <Int32?>]`: The total number of users in the given managed tenant. Optional. Read-only.

## RELATED LINKS

