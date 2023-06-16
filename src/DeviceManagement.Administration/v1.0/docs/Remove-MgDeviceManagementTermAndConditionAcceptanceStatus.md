---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.administration/remove-mgdevicemanagementtermandconditionacceptancestatus
schema: 2.0.0
---

# Remove-MgDeviceManagementTermAndConditionAcceptanceStatus

## SYNOPSIS
Delete navigation property acceptanceStatuses for deviceManagement

## SYNTAX

### Delete (Default)
```
Remove-MgDeviceManagementTermAndConditionAcceptanceStatus -TermsAndConditionsAcceptanceStatusId <String>
 -TermsAndConditionsId <String> [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-MgDeviceManagementTermAndConditionAcceptanceStatus
 -InputObject <IDeviceManagementAdministrationIdentity> [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Delete navigation property acceptanceStatuses for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -IfMatch
ETag

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity
Parameter Sets: DeleteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -TermsAndConditionsAcceptanceStatusId
The unique identifier of termsAndConditionsAcceptanceStatus

```yaml
Type: System.String
Parameter Sets: Delete
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermsAndConditionsId
The unique identifier of termsAndConditions

```yaml
Type: System.String
Parameter Sets: Delete
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IDeviceManagementAdministrationIdentity>`: Identity Parameter
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[ComplianceManagementPartnerId <String>]`: The unique identifier of complianceManagementPartner
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: The unique identifier of deviceAndAppManagementRoleAssignment
  - `[DeviceManagementExchangeConnectorId <String>]`: The unique identifier of deviceManagementExchangeConnector
  - `[DeviceManagementPartnerId <String>]`: The unique identifier of deviceManagementPartner
  - `[IosUpdateDeviceStatusId <String>]`: The unique identifier of iosUpdateDeviceStatus
  - `[MobileThreatDefenseConnectorId <String>]`: The unique identifier of mobileThreatDefenseConnector
  - `[RemoteAssistancePartnerId <String>]`: The unique identifier of remoteAssistancePartner
  - `[ResourceOperationId <String>]`: The unique identifier of resourceOperation
  - `[RoleAssignmentId <String>]`: The unique identifier of roleAssignment
  - `[RoleDefinitionId <String>]`: The unique identifier of roleDefinition
  - `[TelecomExpenseManagementPartnerId <String>]`: The unique identifier of telecomExpenseManagementPartner
  - `[TermsAndConditionsAcceptanceStatusId <String>]`: The unique identifier of termsAndConditionsAcceptanceStatus
  - `[TermsAndConditionsAssignmentId <String>]`: The unique identifier of termsAndConditionsAssignment
  - `[TermsAndConditionsId <String>]`: The unique identifier of termsAndConditions

## RELATED LINKS

