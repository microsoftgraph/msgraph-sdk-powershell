---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprinttaskdefinition
schema: 2.0.0
---

# Update-MgPrintTaskDefinition

## SYNOPSIS
Update the navigation property taskDefinitions in print

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrintTaskDefinition -PrintTaskDefinitionId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphAppIdentity>] [-DisplayName <String>] [-Id <String>]
 [-Tasks <IMicrosoftGraphPrintTask[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgPrintTaskDefinition -PrintTaskDefinitionId <String>
 -BodyParameter <IMicrosoftGraphPrintTaskDefinition> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrintTaskDefinition -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphAppIdentity>] [-DisplayName <String>] [-Id <String>]
 [-Tasks <IMicrosoftGraphPrintTask[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrintTaskDefinition -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintTaskDefinition> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property taskDefinitions in print

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
Type: IMicrosoftGraphPrintTaskDefinition
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
Type: IMicrosoftGraphAppIdentity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IDevicesCloudPrintIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrintTaskDefinitionId
key: id of printTaskDefinition

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tasks
.
To construct, see NOTES section for TASKS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintTask[]
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintTaskDefinition
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrintTaskDefinition\>: printTaskDefinition
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

CREATEDBY \<IMicrosoftGraphAppIdentity\>: appIdentity
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
  \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
  \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
  \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.

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

TASKS \<IMicrosoftGraphPrintTask\[\]\>: .
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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprinttaskdefinition](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprinttaskdefinition)

