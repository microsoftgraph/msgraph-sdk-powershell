---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/invoke-mgselfprivilegedroleactivate
schema: 2.0.0
---

# Invoke-MgSelfPrivilegedRoleActivate

## SYNOPSIS
Invoke action selfActivate

## SYNTAX

### SelfExpanded (Default)
```
Invoke-MgSelfPrivilegedRoleActivate -PrivilegedRoleId <String> [-Duration <String>] [-Reason <String>]
 [-TicketNumber <String>] [-TicketSystem <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Self
```
Invoke-MgSelfPrivilegedRoleActivate -PrivilegedRoleId <String>
 -BodyParameter <IPathsFneytmPrivilegedrolesPrivilegedroleIdMicrosoftGraphSelfactivatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SelfViaIdentity
```
Invoke-MgSelfPrivilegedRoleActivate -InputObject <IIdentityAzureAdpimIdentity>
 -BodyParameter <IPathsFneytmPrivilegedrolesPrivilegedroleIdMicrosoftGraphSelfactivatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SelfViaIdentityExpanded
```
Invoke-MgSelfPrivilegedRoleActivate -InputObject <IIdentityAzureAdpimIdentity> [-Duration <String>]
 [-Reason <String>] [-TicketNumber <String>] [-TicketSystem <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action selfActivate

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
Type: Microsoft.Graph.PowerShell.Models.IPathsFneytmPrivilegedrolesPrivilegedroleIdMicrosoftGraphSelfactivatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Self, SelfViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Duration
.

```yaml
Type: System.String
Parameter Sets: SelfExpanded, SelfViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAzureAdpimIdentity
Parameter Sets: SelfViaIdentity, SelfViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -PrivilegedRoleId
key: privilegedRole-id of privilegedRole

```yaml
Type: System.String
Parameter Sets: Self, SelfExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Reason
.

```yaml
Type: System.String
Parameter Sets: SelfExpanded, SelfViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TicketNumber
.

```yaml
Type: System.String
Parameter Sets: SelfExpanded, SelfViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TicketSystem
.

```yaml
Type: System.String
Parameter Sets: SelfExpanded, SelfViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityAzureAdpimIdentity

### Microsoft.Graph.PowerShell.Models.IPathsFneytmPrivilegedrolesPrivilegedroleIdMicrosoftGraphSelfactivatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignment

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPathsFneytmPrivilegedrolesPrivilegedroleIdMicrosoftGraphSelfactivatePostRequestbodyContentApplicationJsonSchema>: .
  - `[Duration <String>]`: 
  - `[Reason <String>]`: 
  - `[TicketNumber <String>]`: 
  - `[TicketSystem <String>]`: 

#### INPUTOBJECT <IIdentityAzureAdpimIdentity>: Identity Parameter
  - `[PrivilegedApprovalId <String>]`: key: privilegedApproval-id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: privilegedOperationEvent-id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: privilegedRoleAssignment-id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: privilegedRoleAssignmentRequest-id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: privilegedRole-id of privilegedRole

## RELATED LINKS

