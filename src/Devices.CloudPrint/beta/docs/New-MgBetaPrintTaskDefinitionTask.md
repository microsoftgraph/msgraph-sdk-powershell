---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.cloudprint/new-mgbetaprinttaskdefinitiontask
schema: 2.0.0
---

# New-MgBetaPrintTaskDefinitionTask

## SYNOPSIS
Create new navigation property to tasks for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPrintTaskDefinitionTask -PrintTaskDefinitionId <String> [-AdditionalProperties <Hashtable>]
 [-Definition <IMicrosoftGraphPrintTaskDefinition>] [-Id <String>] [-ParentUrl <String>]
 [-Status <IMicrosoftGraphPrintTaskStatus>] [-Trigger <IMicrosoftGraphPrintTaskTrigger>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaPrintTaskDefinitionTask -PrintTaskDefinitionId <String> -BodyParameter <IMicrosoftGraphPrintTask>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaPrintTaskDefinitionTask -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintTask> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaPrintTaskDefinitionTask -InputObject <IDevicesCloudPrintIdentity>
 [-AdditionalProperties <Hashtable>] [-Definition <IMicrosoftGraphPrintTaskDefinition>] [-Id <String>]
 [-ParentUrl <String>] [-Status <IMicrosoftGraphPrintTaskStatus>] [-Trigger <IMicrosoftGraphPrintTaskTrigger>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to tasks for print

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
```

Get-MgBetaPrintTaskDefinitionTask -PrintTaskDefinitionId $printTaskDefinitionId

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printTask
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTask
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Definition
printTaskDefinition
To construct, see NOTES section for DEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ParentUrl
The URL for the print entity that triggered this task.
For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrintTaskDefinitionId
The unique identifier of printTaskDefinition

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
printTaskStatus
To construct, see NOTES section for STATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTaskStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Trigger
printTaskTrigger
To construct, see NOTES section for TRIGGER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTaskTrigger
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTask

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTask

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPrintTask>`: printTask
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppId <String>]`: Refers to the unique identifier representing Application Id in the Azure Active Directory.
      - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
      - `[ServicePrincipalId <String>]`: Refers to the unique identifier indicating Service Principal Id in Azure Active Directory for the corresponding App.
      - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
    - `[DisplayName <String>]`: The name of the printTaskDefinition.
    - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
  - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
  - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
    - `[State <String>]`: printTaskProcessingState
  - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[Event <String>]`: printEvent

`DEFINITION <IMicrosoftGraphPrintTaskDefinition>`: printTaskDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppId <String>]`: Refers to the unique identifier representing Application Id in the Azure Active Directory.
    - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
    - `[ServicePrincipalId <String>]`: Refers to the unique identifier indicating Service Principal Id in Azure Active Directory for the corresponding App.
    - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
  - `[DisplayName <String>]`: The name of the printTaskDefinition.
  - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
    - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
      - `[State <String>]`: printTaskProcessingState
    - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[Event <String>]`: printEvent

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

`STATUS <IMicrosoftGraphPrintTaskStatus>`: printTaskStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
  - `[State <String>]`: printTaskProcessingState

`TRIGGER <IMicrosoftGraphPrintTaskTrigger>`: printTaskTrigger
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppId <String>]`: Refers to the unique identifier representing Application Id in the Azure Active Directory.
      - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
      - `[ServicePrincipalId <String>]`: Refers to the unique identifier indicating Service Principal Id in Azure Active Directory for the corresponding App.
      - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
    - `[DisplayName <String>]`: The name of the printTaskDefinition.
    - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
      - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
        - `[State <String>]`: printTaskProcessingState
      - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
  - `[Event <String>]`: printEvent

## RELATED LINKS

