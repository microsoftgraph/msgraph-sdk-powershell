---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/restart-mgapplicationsynchronizationjob
schema: 2.0.0
---

# Restart-MgApplicationSynchronizationJob

## SYNOPSIS
Invoke action restart

## SYNTAX

### RestartExpanded (Default)
```
Restart-MgApplicationSynchronizationJob -ApplicationId <String> -SynchronizationJobId <String>
 [-AdditionalProperties <Hashtable>] [-Criteria <IMicrosoftGraphSynchronizationJobRestartCriteria>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Restart
```
Restart-MgApplicationSynchronizationJob -ApplicationId <String> -SynchronizationJobId <String>
 -BodyParameter <IPaths113Dr1CApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### RestartViaIdentityExpanded
```
Restart-MgApplicationSynchronizationJob -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Criteria <IMicrosoftGraphSynchronizationJobRestartCriteria>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### RestartViaIdentity
```
Restart-MgApplicationSynchronizationJob -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths113Dr1CApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action restart

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: RestartExpanded, RestartViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationId
key: id of application

```yaml
Type: String
Parameter Sets: RestartExpanded, Restart
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPaths113Dr1CApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Restart, RestartViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Criteria
synchronizationJobRestartCriteria
To construct, see NOTES section for CRITERIA properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationJobRestartCriteria
Parameter Sets: RestartExpanded, RestartViaIdentityExpanded
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
Type: IApplicationsIdentity
Parameter Sets: RestartViaIdentityExpanded, RestartViaIdentity
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
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationJobId
key: id of synchronizationJob

```yaml
Type: String
Parameter Sets: RestartExpanded, Restart
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths113Dr1CApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths113Dr1CApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Criteria <IMicrosoftGraphSynchronizationJobRestartCriteria>]`: synchronizationJobRestartCriteria
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ResetScope <String>]`: synchronizationJobRestartScope

CRITERIA <IMicrosoftGraphSynchronizationJobRestartCriteria>: synchronizationJobRestartCriteria
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ResetScope <String>]`: synchronizationJobRestartScope

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[UserId <String>]`: key: id of user

## RELATED LINKS
