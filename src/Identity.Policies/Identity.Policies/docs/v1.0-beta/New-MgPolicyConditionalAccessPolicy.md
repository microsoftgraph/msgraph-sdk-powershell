---
external help file:
Module Name: Microsoft.Graph.Identity.Policies
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.policies/new-mgpolicyconditionalaccesspolicy
schema: 2.0.0
---

# New-MgPolicyConditionalAccessPolicy

## SYNOPSIS
Create new navigation property to conditionalAccessPolicies for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyConditionalAccessPolicy [-ApplicationEnforcedRestrictionIsEnabled]
 [-CloudAppSecurityCloudAppSecurityType <String>] [-CloudAppSecurityIsEnabled]
 [-Conditions <IMicrosoftGraphConditionalAccessConditionSet>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-GrantControlBuiltInControls <String[]>]
 [-GrantControlCustomAuthenticationFactors <String[]>] [-GrantControlOperator <String>]
 [-GrantControlTermsOfUse <String[]>] [-Id <String>] [-ModifiedDateTime <DateTime>]
 [-PersistentBrowserIsEnabled] [-PersistentBrowserMode <String>] [-SignInFrequencyIsEnabled]
 [-SignInFrequencyType <String>] [-SignInFrequencyValue <Int32>] [-State <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgPolicyConditionalAccessPolicy -BodyParameter <IMicrosoftGraphConditionalAccessPolicy> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to conditionalAccessPolicies for policies

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

### -ApplicationEnforcedRestrictionIsEnabled
.

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

### -BodyParameter
conditionalAccessPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudAppSecurityCloudAppSecurityType
cloudAppSecuritySessionControlType

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

### -CloudAppSecurityIsEnabled
.

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

### -Conditions
conditionalAccessConditionSet
To construct, see NOTES section for CONDITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessConditionSet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

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

### -Description
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

### -DisplayName
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

### -GrantControlBuiltInControls
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantControlCustomAuthenticationFactors
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantControlOperator
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

### -GrantControlTermsOfUse
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
.

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

### -PersistentBrowserIsEnabled
.

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

### -PersistentBrowserMode
persistentBrowserSessionMode

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

### -SignInFrequencyIsEnabled
.

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

### -SignInFrequencyType
signinFrequencyType

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

### -SignInFrequencyValue
.

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

### -State
conditionalAccessPolicyState

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConditionalAccessPolicy>: conditionalAccessPolicy
  - `[Id <String>]`: Read-only.
  - `[ApplicationEnforcedRestrictionIsEnabled <Boolean?>]`: 
  - `[CloudAppSecurityCloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
  - `[CloudAppSecurityIsEnabled <Boolean?>]`: 
  - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet>]`: conditionalAccessConditionSet
    - `[ApplicationExcludeApplications <String[]>]`: 
    - `[ApplicationIncludeApplications <String[]>]`: 
    - `[ApplicationIncludeUserActions <String[]>]`: 
    - `[ClientAppTypes <String[]>]`: 
    - `[DeviceExcludeDeviceStates <String[]>]`: 
    - `[DeviceIncludeDeviceStates <String[]>]`: 
    - `[DeviceStateExcludeStates <String[]>]`: 
    - `[DeviceStateIncludeStates <String[]>]`: 
    - `[LocationExcludeLocations <String[]>]`: 
    - `[LocationIncludeLocations <String[]>]`: 
    - `[PlatformExcludePlatforms <String[]>]`: 
    - `[PlatformIncludePlatforms <String[]>]`: 
    - `[SignInRiskLevels <String[]>]`: 
    - `[UserExcludeGroups <String[]>]`: 
    - `[UserExcludeRoles <String[]>]`: 
    - `[UserExcludeUsers <String[]>]`: 
    - `[UserIncludeGroups <String[]>]`: 
    - `[UserIncludeRoles <String[]>]`: 
    - `[UserIncludeUsers <String[]>]`: 
    - `[UserRiskLevels <String[]>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[GrantControlBuiltInControls <String[]>]`: 
  - `[GrantControlCustomAuthenticationFactors <String[]>]`: 
  - `[GrantControlOperator <String>]`: 
  - `[GrantControlTermsOfUse <String[]>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 
  - `[PersistentBrowserIsEnabled <Boolean?>]`: 
  - `[PersistentBrowserMode <String>]`: persistentBrowserSessionMode
  - `[SignInFrequencyIsEnabled <Boolean?>]`: 
  - `[SignInFrequencyType <String>]`: signinFrequencyType
  - `[SignInFrequencyValue <Int32?>]`: 
  - `[State <String>]`: conditionalAccessPolicyState

CONDITIONS <IMicrosoftGraphConditionalAccessConditionSet>: conditionalAccessConditionSet
  - `[ApplicationExcludeApplications <String[]>]`: 
  - `[ApplicationIncludeApplications <String[]>]`: 
  - `[ApplicationIncludeUserActions <String[]>]`: 
  - `[ClientAppTypes <String[]>]`: 
  - `[DeviceExcludeDeviceStates <String[]>]`: 
  - `[DeviceIncludeDeviceStates <String[]>]`: 
  - `[DeviceStateExcludeStates <String[]>]`: 
  - `[DeviceStateIncludeStates <String[]>]`: 
  - `[LocationExcludeLocations <String[]>]`: 
  - `[LocationIncludeLocations <String[]>]`: 
  - `[PlatformExcludePlatforms <String[]>]`: 
  - `[PlatformIncludePlatforms <String[]>]`: 
  - `[SignInRiskLevels <String[]>]`: 
  - `[UserExcludeGroups <String[]>]`: 
  - `[UserExcludeRoles <String[]>]`: 
  - `[UserExcludeUsers <String[]>]`: 
  - `[UserIncludeGroups <String[]>]`: 
  - `[UserIncludeRoles <String[]>]`: 
  - `[UserIncludeUsers <String[]>]`: 
  - `[UserRiskLevels <String[]>]`: 

## RELATED LINKS

