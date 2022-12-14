---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.directorymanagement/new-mgdirectoryonpremissynchronization
schema: 2.0.0
---

# New-MgBetaDirectoryOnPremisSynchronization

## SYNOPSIS
Create new navigation property to onPremisesSynchronization for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDirectoryOnPremisSynchronization [-AdditionalProperties <Hashtable>]
 [-Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]
 [-Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDirectoryOnPremisSynchronization -BodyParameter <IMicrosoftGraphOnPremisesDirectorySynchronization>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to onPremisesSynchronization for directory

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
onPremisesDirectorySynchronization
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Configuration
onPremisesDirectorySynchronizationConfiguration
To construct, please use Get-Help -Online and see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Features
onPremisesDirectorySynchronizationFeature
To construct, please use Get-Help -Online and see NOTES section for FEATURES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronizationFeature
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOnPremisesDirectorySynchronization>: onPremisesDirectorySynchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlertThreshold <Int32?>]`: 
      - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
    - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: 
    - `[SynchronizationInterval <TimeSpan?>]`: 
  - `[Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>]`: onPremisesDirectorySynchronizationFeature
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: 
    - `[BlockSoftMatchEnabled <Boolean?>]`: 
    - `[BypassDirSyncOverridesEnabled <Boolean?>]`: 
    - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: 
    - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: 
    - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: 
    - `[DeviceWritebackEnabled <Boolean?>]`: 
    - `[DirectoryExtensionsEnabled <Boolean?>]`: 
    - `[FopeConflictResolutionEnabled <Boolean?>]`: 
    - `[GroupWriteBackEnabled <Boolean?>]`: 
    - `[PasswordSyncEnabled <Boolean?>]`: 
    - `[PasswordWritebackEnabled <Boolean?>]`: 
    - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: 
    - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: 
    - `[SoftMatchOnUpnEnabled <Boolean?>]`: 
    - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: 
    - `[UnifiedGroupWritebackEnabled <Boolean?>]`: 
    - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: 
    - `[UserWritebackEnabled <Boolean?>]`: 

CONFIGURATION <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>: onPremisesDirectorySynchronizationConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AlertThreshold <Int32?>]`: 
    - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
  - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: 
  - `[SynchronizationInterval <TimeSpan?>]`: 

FEATURES <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>: onPremisesDirectorySynchronizationFeature
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: 
  - `[BlockSoftMatchEnabled <Boolean?>]`: 
  - `[BypassDirSyncOverridesEnabled <Boolean?>]`: 
  - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: 
  - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: 
  - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: 
  - `[DeviceWritebackEnabled <Boolean?>]`: 
  - `[DirectoryExtensionsEnabled <Boolean?>]`: 
  - `[FopeConflictResolutionEnabled <Boolean?>]`: 
  - `[GroupWriteBackEnabled <Boolean?>]`: 
  - `[PasswordSyncEnabled <Boolean?>]`: 
  - `[PasswordWritebackEnabled <Boolean?>]`: 
  - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: 
  - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: 
  - `[SoftMatchOnUpnEnabled <Boolean?>]`: 
  - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: 
  - `[UnifiedGroupWritebackEnabled <Boolean?>]`: 
  - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: 
  - `[UserWritebackEnabled <Boolean?>]`: 

## RELATED LINKS

