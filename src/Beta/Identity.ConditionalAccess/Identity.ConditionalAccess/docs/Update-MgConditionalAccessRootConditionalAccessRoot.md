---
external help file:
Module Name: Microsoft.Graph.Identity.ConditionalAccess
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.conditionalaccess/update-mgconditionalaccessrootconditionalaccessroot
schema: 2.0.0
---

# Update-MgConditionalAccessRootConditionalAccessRoot

## SYNOPSIS
Update conditionalAccess

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgConditionalAccessRootConditionalAccessRoot [-Id <String>]
 [-NamedLocations <IMicrosoftGraphNamedLocation[]>] [-Policies <IMicrosoftGraphConditionalAccessPolicy[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgConditionalAccessRootConditionalAccessRoot -BodyParameter <IMicrosoftGraphConditionalAccessRoot>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update conditionalAccess

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

### -BodyParameter
conditionalAccessRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NamedLocations
.
To construct, see NOTES section for NAMEDLOCATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNamedLocation[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Policies
.
To construct, see NOTES section for POLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessRoot

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphConditionalAccessRoot>: conditionalAccessRoot
  - `[Id <String>]`: Read-only.
  - `[NamedLocations <IMicrosoftGraphNamedLocation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[Policies <IMicrosoftGraphConditionalAccessPolicy[]>]`: 
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

#### NAMEDLOCATIONS <IMicrosoftGraphNamedLocation[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 

#### POLICIES <IMicrosoftGraphConditionalAccessPolicy[]>: .
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

