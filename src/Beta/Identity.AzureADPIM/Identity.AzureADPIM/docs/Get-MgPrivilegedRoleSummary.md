---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/get-mgprivilegedrolesummary
schema: 2.0.0
---

# Get-MgPrivilegedRoleSummary

## SYNOPSIS
Get summary from privilegedRoles

## SYNTAX

### Get (Default)
```
Get-MgPrivilegedRoleSummary -PrivilegedRoleId <String> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgPrivilegedRoleSummary -InputObject <IIdentityAzureAdpimIdentity> [-Expand <String[]>]
 [-Select <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get summary from privilegedRoles

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

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
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
Parameter Sets: GetViaIdentity
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
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

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

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleSummary

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IIdentityAzureAdpimIdentity>: Identity Parameter
  - `[PrivilegedApprovalId <String>]`: key: privilegedApproval-id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: privilegedOperationEvent-id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: privilegedRoleAssignment-id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: privilegedRoleAssignmentRequest-id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: privilegedRole-id of privilegedRole

## RELATED LINKS

