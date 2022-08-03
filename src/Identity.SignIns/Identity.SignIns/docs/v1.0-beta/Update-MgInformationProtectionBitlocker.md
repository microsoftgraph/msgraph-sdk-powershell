---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mginformationprotectionbitlocker
schema: 2.0.0
---

# Update-MgInformationProtectionBitlocker

## SYNOPSIS
Update the navigation property bitlocker in informationProtection

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgInformationProtectionBitlocker [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgInformationProtectionBitlocker -BodyParameter <IMicrosoftGraphBitlocker> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property bitlocker in informationProtection

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
bitlocker
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBitlocker
Parameter Sets: Update
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -RecoveryKeys
The recovery keys associated with the bitlocker entity.
To construct, please use Get-Help -Online and see NOTES section for RECOVERYKEYS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBitlockerRecoveryKey[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBitlocker

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphBitlocker>: bitlocker
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Azure Active Directory.
    - `[DeviceId <String>]`: ID of the device the BitLocker key is originally backed up from.
    - `[Key <String>]`: The BitLocker recovery key.
    - `[VolumeType <String>]`: volumeType

RECOVERYKEYS <IMicrosoftGraphBitlockerRecoveryKey[]>: The recovery keys associated with the bitlocker entity.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Azure Active Directory.
  - `[DeviceId <String>]`: ID of the device the BitLocker key is originally backed up from.
  - `[Key <String>]`: The BitLocker recovery key.
  - `[VolumeType <String>]`: volumeType

## RELATED LINKS

