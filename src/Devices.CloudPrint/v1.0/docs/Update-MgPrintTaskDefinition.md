---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.cloudprint/update-mgprinttaskdefinition
schema: 2.0.0
---

# Update-MgPrintTaskDefinition

## SYNOPSIS
Update a task definition.
For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrintTaskDefinition -PrintTaskDefinitionId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphAppIdentity>] [-DisplayName <String>] [-Id <String>]
 [-Tasks <IMicrosoftGraphPrintTask[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPrintTaskDefinition -PrintTaskDefinitionId <String>
 -BodyParameter <IMicrosoftGraphPrintTaskDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrintTaskDefinition -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintTaskDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrintTaskDefinition -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphAppIdentity>] [-DisplayName <String>] [-Id <String>]
 [-Tasks <IMicrosoftGraphPrintTask[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update a task definition.
For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
```

$params = @{
	displayName = "Test TaskDefinitionName"
	createdBy = @{
		displayName = "Requesting App Display Name"
	}
}

Update-MgPrintTaskDefinition -PrintTaskDefinitionId $printTaskDefinitionId -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printTaskDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
appIdentity
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppIdentity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the printTaskDefinition.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PrintTaskDefinitionId
The unique identifier of printTaskDefinition

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tasks
A list of tasks that have been created based on this definition.
The list includes currently running tasks and recently completed tasks.
Read-only.
To construct, see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTask[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPrintTaskDefinition>`: printTaskDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppId <String>]`: Refers to the unique ID representing application in Microsoft Entra ID.
    - `[DisplayName <String>]`: Refers to the application name displayed in the Microsoft Entra admin center.
    - `[ServicePrincipalId <String>]`: Refers to the unique ID for the service principal in Microsoft Entra ID.
    - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
  - `[DisplayName <String>]`: The name of the printTaskDefinition.
  - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/v1.0/print/printers/{printerId}/jobs/{jobId}. Read-only.
    - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
      - `[State <String>]`: printTaskProcessingState
    - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[Event <String>]`: printEvent

`CREATEDBY <IMicrosoftGraphAppIdentity>`: appIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppId <String>]`: Refers to the unique ID representing application in Microsoft Entra ID.
  - `[DisplayName <String>]`: Refers to the application name displayed in the Microsoft Entra admin center.
  - `[ServicePrincipalId <String>]`: Refers to the unique ID for the service principal in Microsoft Entra ID.
  - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.

`INPUTOBJECT <IDevicesCloudPrintIdentity>`: Identity Parameter
  - `[GroupId <String>]`: The unique identifier of group
  - `[PrintConnectorId <String>]`: The unique identifier of printConnector
  - `[PrintDocumentId <String>]`: The unique identifier of printDocument
  - `[PrintJobId <String>]`: The unique identifier of printJob
  - `[PrintOperationId <String>]`: The unique identifier of printOperation
  - `[PrintServiceEndpointId <String>]`: The unique identifier of printServiceEndpoint
  - `[PrintServiceId <String>]`: The unique identifier of printService
  - `[PrintTaskDefinitionId <String>]`: The unique identifier of printTaskDefinition
  - `[PrintTaskId <String>]`: The unique identifier of printTask
  - `[PrintTaskTriggerId <String>]`: The unique identifier of printTaskTrigger
  - `[PrinterId <String>]`: The unique identifier of printer
  - `[PrinterShareId <String>]`: The unique identifier of printerShare
  - `[UserId <String>]`: The unique identifier of user

`TASKS <IMicrosoftGraphPrintTask[]>`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppId <String>]`: Refers to the unique ID representing application in Microsoft Entra ID.
      - `[DisplayName <String>]`: Refers to the application name displayed in the Microsoft Entra admin center.
      - `[ServicePrincipalId <String>]`: Refers to the unique ID for the service principal in Microsoft Entra ID.
      - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
    - `[DisplayName <String>]`: The name of the printTaskDefinition.
    - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
  - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/v1.0/print/printers/{printerId}/jobs/{jobId}. Read-only.
  - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
    - `[State <String>]`: printTaskProcessingState
  - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[Event <String>]`: printEvent

## RELATED LINKS

