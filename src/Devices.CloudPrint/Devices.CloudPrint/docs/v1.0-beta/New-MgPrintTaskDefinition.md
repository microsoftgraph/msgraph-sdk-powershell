---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprinttaskdefinition
schema: 2.0.0
---

# New-MgPrintTaskDefinition

## SYNOPSIS
List of abstract definition for a task that can be triggered when various events occur within Universal Print.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgPrintTaskDefinition [-AdditionalProperties <Hashtable>] [-CreatedBy <IMicrosoftGraphAppIdentity>]
 [-DisplayName <String>] [-Id <String>] [-Tasks <IMicrosoftGraphPrintTask1[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgPrintTaskDefinition -BodyParameter <IMicrosoftGraphPrintTaskDefinition1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
List of abstract definition for a task that can be triggered when various events occur within Universal Print.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition1
Parameter Sets: Create1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTask1[]
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrintTaskDefinition1>: printTaskDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
    - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
    - `[ServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
    - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
  - `[DisplayName <String>]`: The name of the printTaskDefinition.
  - `[Tasks <IMicrosoftGraphPrintTask1[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
    - `[Id <String>]`: Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition1>]`: printTaskDefinition
    - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
    - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
      - `[State <String>]`: printTaskProcessingState
    - `[Trigger <IMicrosoftGraphPrintTaskTrigger1>]`: printTaskTrigger
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition1>]`: printTaskDefinition
      - `[Event <String>]`: printEvent

CREATEDBY <IMicrosoftGraphAppIdentity>: appIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
  - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
  - `[ServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
  - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.

TASKS <IMicrosoftGraphPrintTask1[]>: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
  - `[Id <String>]`: Read-only.
  - `[Definition <IMicrosoftGraphPrintTaskDefinition1>]`: printTaskDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
      - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
      - `[ServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
      - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
    - `[DisplayName <String>]`: The name of the printTaskDefinition.
    - `[Tasks <IMicrosoftGraphPrintTask1[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
  - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
  - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
    - `[State <String>]`: printTaskProcessingState
  - `[Trigger <IMicrosoftGraphPrintTaskTrigger1>]`: printTaskTrigger
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition1>]`: printTaskDefinition
    - `[Event <String>]`: printEvent

## RELATED LINKS

