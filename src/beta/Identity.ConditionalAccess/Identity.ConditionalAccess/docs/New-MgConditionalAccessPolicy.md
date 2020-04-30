---
external help file:
Module Name: Microsoft.Graph.Identity.ConditionalAccess
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.conditionalaccess/new-mgconditionalaccesspolicy
schema: 2.0.0
---

# New-MgConditionalAccessPolicy

## SYNOPSIS
Create new navigation property to policies for conditionalAccess

## SYNTAX

### CreateExpanded (Default)
```
New-MgConditionalAccessPolicy [-ApplicationEnforcedRestrictionIsEnabled]
 [-ApplicationExcludeApplications <String[]>] [-ApplicationIncludeApplications <String[]>]
 [-ApplicationIncludeUserActions <String[]>] [-CloudAppSecurityCloudAppSecurityType <String>]
 [-CloudAppSecurityIsEnabled] [-ConditionClientAppTypes <String[]>] [-ConditionSignInRiskLevels <String[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DeviceStateExcludeStates <String[]>]
 [-DeviceStateIncludeStates <String[]>] [-DisplayName <String>] [-GrantControlBuiltInControls <String[]>]
 [-GrantControlCustomAuthenticationFactors <String[]>] [-GrantControlOperator <String>]
 [-GrantControlTermsOfUse <String[]>] [-Id <String>] [-LocationExcludeLocations <String[]>]
 [-LocationIncludeLocations <String[]>] [-ModifiedDateTime <DateTime>] [-PersistentBrowserIsEnabled]
 [-PersistentBrowserMode <String>] [-PlatformExcludePlatforms <String[]>]
 [-PlatformIncludePlatforms <String[]>] [-SignInFrequencyIsEnabled] [-SignInFrequencyType <String>]
 [-SignInFrequencyValue <Int32>] [-State <String>] [-UserExcludeGroups <String[]>]
 [-UserExcludeRoles <String[]>] [-UserExcludeUsers <String[]>] [-UserIncludeGroups <String[]>]
 [-UserIncludeRoles <String[]>] [-UserIncludeUsers <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgConditionalAccessPolicy -BodyParameter <IMicrosoftGraphConditionalAccessPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to policies for conditionalAccess

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
Dynamic: False
```

### -ApplicationExcludeApplications
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
Dynamic: False
```

### -ApplicationIncludeApplications
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
Dynamic: False
```

### -ApplicationIncludeUserActions
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -ConditionClientAppTypes
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
Dynamic: False
```

### -ConditionSignInRiskLevels
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -DeviceStateExcludeStates
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
Dynamic: False
```

### -DeviceStateIncludeStates
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -LocationExcludeLocations
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
Dynamic: False
```

### -LocationIncludeLocations
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -PlatformExcludePlatforms
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
Dynamic: False
```

### -PlatformIncludePlatforms
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -UserExcludeGroups
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
Dynamic: False
```

### -UserExcludeRoles
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
Dynamic: False
```

### -UserExcludeUsers
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
Dynamic: False
```

### -UserIncludeGroups
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
Dynamic: False
```

### -UserIncludeRoles
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
Dynamic: False
```

### -UserIncludeUsers
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphConditionalAccessPolicy>: conditionalAccessPolicy
  - `[Id <String>]`: Read-only.
  - `[ApplicationEnforcedRestrictionIsEnabled <Boolean?>]`: 
  - `[ApplicationExcludeApplications <String[]>]`: 
  - `[ApplicationIncludeApplications <String[]>]`: 
  - `[ApplicationIncludeUserActions <String[]>]`: 
  - `[CloudAppSecurityCloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
  - `[CloudAppSecurityIsEnabled <Boolean?>]`: 
  - `[ConditionClientAppTypes <String[]>]`: 
  - `[ConditionSignInRiskLevels <String[]>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DeviceStateExcludeStates <String[]>]`: 
  - `[DeviceStateIncludeStates <String[]>]`: 
  - `[DisplayName <String>]`: 
  - `[GrantControlBuiltInControls <String[]>]`: 
  - `[GrantControlCustomAuthenticationFactors <String[]>]`: 
  - `[GrantControlOperator <String>]`: 
  - `[GrantControlTermsOfUse <String[]>]`: 
  - `[LocationExcludeLocations <String[]>]`: 
  - `[LocationIncludeLocations <String[]>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 
  - `[PersistentBrowserIsEnabled <Boolean?>]`: 
  - `[PersistentBrowserMode <String>]`: persistentBrowserSessionMode
  - `[PlatformExcludePlatforms <String[]>]`: 
  - `[PlatformIncludePlatforms <String[]>]`: 
  - `[SignInFrequencyIsEnabled <Boolean?>]`: 
  - `[SignInFrequencyType <String>]`: signinFrequencyType
  - `[SignInFrequencyValue <Int32?>]`: 
  - `[State <String>]`: conditionalAccessPolicyState
  - `[UserExcludeGroups <String[]>]`: 
  - `[UserExcludeRoles <String[]>]`: 
  - `[UserExcludeUsers <String[]>]`: 
  - `[UserIncludeGroups <String[]>]`: 
  - `[UserIncludeRoles <String[]>]`: 
  - `[UserIncludeUsers <String[]>]`: 

## RELATED LINKS

