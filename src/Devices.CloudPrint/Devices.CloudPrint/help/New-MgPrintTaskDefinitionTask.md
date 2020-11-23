---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprinttaskdefinitiontask
schema: 2.0.0
---

# New-MgPrintTaskDefinitionTask

## SYNOPSIS
Create new navigation property to tasks for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintTaskDefinitionTask -PrintTaskDefinitionId <String> [-AdditionalProperties <Hashtable>]
 [-Definition <IMicrosoftGraphPrintTaskDefinition>] [-Id <String>] [-ParentUrl <String>]
 [-Status <IMicrosoftGraphPrintTaskStatus>] [-Trigger <IMicrosoftGraphPrintTaskTrigger>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgPrintTaskDefinitionTask -PrintTaskDefinitionId <String> -BodyParameter <IMicrosoftGraphPrintTask>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgPrintTaskDefinitionTask -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-Definition <IMicrosoftGraphPrintTaskDefinition>] [-Id <String>] [-ParentUrl <String>]
 [-Status <IMicrosoftGraphPrintTaskStatus>] [-Trigger <IMicrosoftGraphPrintTaskTrigger>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgPrintTaskDefinitionTask -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintTask> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to tasks for print

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
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
Type: IMicrosoftGraphPrintTask
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
Type: IMicrosoftGraphPrintTaskDefinition
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: String
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
Type: IDevicesCloudPrintIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ParentUrl
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrintTaskDefinitionId
key: id of printTaskDefinition

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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
Type: IMicrosoftGraphPrintTaskStatus
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
Type: IMicrosoftGraphPrintTaskTrigger
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
Type: SwitchParameter
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
Type: SwitchParameter
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTask
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTask
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrintTask\>: printTask
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
      \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
      \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
      \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
    \[DisplayName \<String\>\]: 
    \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
  \[ParentUrl \<String\>\]: 
  \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Description \<String\>\]: 
    \[State \<String\>\]: printTaskProcessingState
  \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
    \[Event \<String\>\]: printEvent

DEFINITION \<IMicrosoftGraphPrintTaskDefinition\>: printTaskDefinition
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
    \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
    \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
    \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
  \[DisplayName \<String\>\]: 
  \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
    \[ParentUrl \<String\>\]: 
    \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Description \<String\>\]: 
      \[State \<String\>\]: printTaskProcessingState
    \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
      \[Event \<String\>\]: printEvent

INPUTOBJECT \<IDevicesCloudPrintIdentity\>: Identity Parameter
  \[GroupId \<String\>\]: 
  \[PeriodEnd \<DateTime?\>\]: 
  \[PeriodStart \<DateTime?\>\]: 
  \[PrintConnectorId \<String\>\]: key: id of printConnector
  \[PrintIdentityId \<String\>\]: key: id of printIdentity
  \[PrintOperationId \<String\>\]: key: id of printOperation
  \[PrintServiceEndpointId \<String\>\]: key: id of printServiceEndpoint
  \[PrintServiceId \<String\>\]: key: id of printService
  \[PrintTaskDefinitionId \<String\>\]: key: id of printTaskDefinition
  \[PrintTaskId \<String\>\]: key: id of printTask
  \[PrintTaskTriggerId \<String\>\]: key: id of printTaskTrigger
  \[PrintUserIdentityId \<String\>\]: key: id of printUserIdentity
  \[PrinterId \<String\>\]: key: id of printer
  \[PrinterId1 \<String\>\]: 
  \[PrinterShareId \<String\>\]: key: id of printerShare
  \[ReportRootId \<String\>\]: key: id of reportRoot
  \[TimeSpanInMinutes \<Int32?\>\]: 
  \[TopListsSize \<Int32?\>\]: 
  \[UserId \<String\>\]: 

STATUS \<IMicrosoftGraphPrintTaskStatus\>: printTaskStatus
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Description \<String\>\]: 
  \[State \<String\>\]: printTaskProcessingState

TRIGGER \<IMicrosoftGraphPrintTaskTrigger\>: printTaskTrigger
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
      \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
      \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
      \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
    \[DisplayName \<String\>\]: 
    \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
      \[ParentUrl \<String\>\]: 
      \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Description \<String\>\]: 
        \[State \<String\>\]: printTaskProcessingState
      \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
  \[Event \<String\>\]: printEvent

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprinttaskdefinitiontask](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprinttaskdefinitiontask)

