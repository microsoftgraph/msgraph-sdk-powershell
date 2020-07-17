---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/new-mgprivilegedroleassignmentpermanent
schema: 2.0.0
---

# New-MgPrivilegedRoleAssignmentPermanent

## SYNOPSIS
Invoke action makePermanent

## SYNTAX

### MakeExpanded (Default)
```
New-MgPrivilegedRoleAssignmentPermanent -PrivilegedRoleAssignmentId <String> [-Reason <String>]
 [-TicketNumber <String>] [-TicketSystem <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Make
```
New-MgPrivilegedRoleAssignmentPermanent -PrivilegedRoleAssignmentId <String>
 -BodyParameter <IPaths1Ao8IriPrivilegedroleassignmentsPrivilegedroleassignmentIdMicrosoftGraphMakepermanentPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### MakeViaIdentity
```
New-MgPrivilegedRoleAssignmentPermanent -InputObject <IIdentityAzureAdpimIdentity>
 -BodyParameter <IPaths1Ao8IriPrivilegedroleassignmentsPrivilegedroleassignmentIdMicrosoftGraphMakepermanentPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### MakeViaIdentityExpanded
```
New-MgPrivilegedRoleAssignmentPermanent -InputObject <IIdentityAzureAdpimIdentity> [-Reason <String>]
 [-TicketNumber <String>] [-TicketSystem <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action makePermanent

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Ao8IriPrivilegedroleassignmentsPrivilegedroleassignmentIdMicrosoftGraphMakepermanentPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Make, MakeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAzureAdpimIdentity
Parameter Sets: MakeViaIdentity, MakeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PrivilegedRoleAssignmentId
key: privilegedRoleAssignment-id of privilegedRoleAssignment

```yaml
Type: System.String
Parameter Sets: Make, MakeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reason
.

```yaml
Type: System.String
Parameter Sets: MakeExpanded, MakeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TicketNumber
.

```yaml
Type: System.String
Parameter Sets: MakeExpanded, MakeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TicketSystem
.

```yaml
Type: System.String
Parameter Sets: MakeExpanded, MakeViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityAzureAdpimIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1Ao8IriPrivilegedroleassignmentsPrivilegedroleassignmentIdMicrosoftGraphMakepermanentPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Ao8IriPrivilegedroleassignmentsPrivilegedroleassignmentIdMicrosoftGraphMakepermanentPostRequestbodyContentApplicationJsonSchema>: .
  - `[Reason <String>]`: 
  - `[TicketNumber <String>]`: 
  - `[TicketSystem <String>]`: 

INPUTOBJECT <IIdentityAzureAdpimIdentity>: Identity Parameter
  - `[PrivilegedApprovalId <String>]`: key: privilegedApproval-id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: privilegedOperationEvent-id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: privilegedRoleAssignment-id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: privilegedRoleAssignmentRequest-id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: privilegedRole-id of privilegedRole

## RELATED LINKS

