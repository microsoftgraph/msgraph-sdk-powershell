---
external help file:
Module Name: Microsoft.Graph.Identity.Domains
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.domains/test-mgdomain
schema: 2.0.0
---

# Test-MgDomain

## SYNOPSIS
Invoke action verify

## SYNTAX

### Verify1 (Default)
```
Test-MgDomain -DomainId <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### VerifyViaIdentity1
```
Test-MgDomain -InputObject <IIdentityDomainsIdentity> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action verify

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

### -DomainId
key: domain-id of domain

```yaml
Type: System.String
Parameter Sets: Verify1
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDomainsIdentity
Parameter Sets: VerifyViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IIdentityDomainsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomain

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IIdentityDomainsIdentity>: Identity Parameter
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[DomainDnsRecordId <String>]`: key: domainDnsRecord-id of domainDnsRecord
  - `[DomainId <String>]`: key: domain-id of domain

## RELATED LINKS

