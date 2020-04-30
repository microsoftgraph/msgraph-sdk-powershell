---
external help file:
Module Name: Microsoft.Graph.Identity.Policies
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.policies/update-mgpolicyroot
schema: 2.0.0
---

# Update-MgPolicyRoot

## SYNOPSIS
Update policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyRoot [-ActivityBasedTimeoutPolicies <IMicrosoftGraphActivityBasedTimeoutPolicy[]>]
 [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>] [-Id <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPolicyRoot -BodyParameter <IMicrosoftGraphPolicyRoot> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update policies

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

### -ActivityBasedTimeoutPolicies
.
To construct, see NOTES section for ACTIVITYBASEDTIMEOUTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphActivityBasedTimeoutPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
policyRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicyRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ClaimsMappingPolicies
.
To construct, see NOTES section for CLAIMSMAPPINGPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphClaimsMappingPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -HomeRealmDiscoveryPolicies
.
To construct, see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHomeRealmDiscoveryPolicy[]
Parameter Sets: UpdateExpanded
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

### -TokenIssuancePolicies
.
To construct, see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TokenLifetimePolicies
.
To construct, see NOTES section for TOKENLIFETIMEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicyRoot

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ACTIVITYBASEDTIMEOUTPOLICIES <IMicrosoftGraphActivityBasedTimeoutPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### BODYPARAMETER <IMicrosoftGraphPolicyRoot>: policyRoot
  - `[Id <String>]`: Read-only.
  - `[ActivityBasedTimeoutPolicies <IMicrosoftGraphActivityBasedTimeoutPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.

#### CLAIMSMAPPINGPOLICIES <IMicrosoftGraphClaimsMappingPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

## RELATED LINKS

