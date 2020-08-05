---
external help file:
Module Name: Microsoft.Graph.Identity.Contracts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.contracts/get-mgcontractmemberobject
schema: 2.0.0
---

# Get-MgContractMemberObject

## SYNOPSIS
Invoke action getMemberObjects

## SYNTAX

### GetExpanded (Default)
```
Get-MgContractMemberObject -ContractId <String> [-SecurityEnabledOnly] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Get
```
Get-MgContractMemberObject -ContractId <String>
 -BodyParameter <IPaths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgContractMemberObject -InputObject <IIdentityContractsIdentity>
 -BodyParameter <IPaths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded
```
Get-MgContractMemberObject -InputObject <IIdentityContractsIdentity> [-SecurityEnabledOnly] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getMemberObjects

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContractId
key: contract-id of contract

```yaml
Type: System.String
Parameter Sets: Get, GetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityContractsIdentity
Parameter Sets: GetViaIdentity, GetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SecurityEnabledOnly
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityContractsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>: .
  - `[SecurityEnabledOnly <Boolean?>]`: 

INPUTOBJECT <IIdentityContractsIdentity>: Identity Parameter
  - `[ContractId <String>]`: key: contract-id of contract

## RELATED LINKS

