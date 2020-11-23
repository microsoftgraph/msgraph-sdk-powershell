---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationsynchronizationtemplateschemadirectory
schema: 2.0.0
---

# New-MgApplicationSynchronizationTemplateSchemaDirectory

## SYNOPSIS
Create new navigation property to directories for applications

## SYNTAX

### CreateExpanded (Default)
```
New-MgApplicationSynchronizationTemplateSchemaDirectory -ApplicationId <String>
 -SynchronizationTemplateId <String> [-AdditionalProperties <Hashtable>] [-Discoverabilities <String>]
 [-DiscoveryDateTime <DateTime>] [-Id <String>] [-Name <String>] [-Objects <IMicrosoftGraphObjectDefinition[]>]
 [-ReadOnly] [-Version <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgApplicationSynchronizationTemplateSchemaDirectory -ApplicationId <String>
 -SynchronizationTemplateId <String> -BodyParameter <IMicrosoftGraphDirectoryDefinition> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgApplicationSynchronizationTemplateSchemaDirectory -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Discoverabilities <String>] [-DiscoveryDateTime <DateTime>]
 [-Id <String>] [-Name <String>] [-Objects <IMicrosoftGraphObjectDefinition[]>] [-ReadOnly] [-Version <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgApplicationSynchronizationTemplateSchemaDirectory -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphDirectoryDefinition> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to directories for applications

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

### -ApplicationId
key: id of application

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

### -BodyParameter
directoryDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryDefinition
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Discoverabilities
directoryDefinitionDiscoverabilities

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

### -DiscoveryDateTime
.

```yaml
Type: DateTime
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
Type: IApplicationsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
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

### -Objects
.
To construct, see NOTES section for OBJECTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphObjectDefinition[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReadOnly
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationTemplateId
key: id of synchronizationTemplate

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

### -Version
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryDefinition
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryDefinition
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphDirectoryDefinition\>: directoryDefinition
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Discoverabilities \<String\>\]: directoryDefinitionDiscoverabilities
  \[DiscoveryDateTime \<DateTime?\>\]: 
  \[Name \<String\>\]: 
  \[Objects \<IMicrosoftGraphObjectDefinition\[\]\>\]: 
    \[Attributes \<IMicrosoftGraphAttributeDefinition\[\]\>\]: 
      \[Anchor \<Boolean?\>\]: 
      \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
        \[Key \<String\>\]: 
        \[Value \<String\>\]: 
      \[CaseExact \<Boolean?\>\]: 
      \[DefaultValue \<String\>\]: 
      \[FlowNullValues \<Boolean?\>\]: 
      \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
        \[Key \<String\>\]: 
        \[Value \<String\>\]: 
      \[Multivalued \<Boolean?\>\]: 
      \[Mutability \<String\>\]: mutability
      \[Name \<String\>\]: 
      \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
        \[ReferencedObjectName \<String\>\]: 
        \[ReferencedProperty \<String\>\]: 
      \[Required \<Boolean?\>\]: 
      \[Type \<String\>\]: attributeType
    \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
    \[Name \<String\>\]: 
    \[SupportedApis \<String\[\]\>\]: 
  \[ReadOnly \<Boolean?\>\]: 
  \[Version \<String\>\]: 

INPUTOBJECT \<IApplicationsIdentity\>: Identity Parameter
  \[AppRoleAssignmentId \<String\>\]: key: id of appRoleAssignment
  \[ApplicationId \<String\>\]: key: id of application
  \[ApplicationTemplateId \<String\>\]: key: id of applicationTemplate
  \[ConnectorGroupId \<String\>\]: key: id of connectorGroup
  \[ConnectorId \<String\>\]: key: id of connector
  \[DelegatedPermissionClassificationId \<String\>\]: key: id of delegatedPermissionClassification
  \[DirectoryDefinitionId \<String\>\]: key: id of directoryDefinition
  \[EndpointId \<String\>\]: key: id of endpoint
  \[ExtensionPropertyId \<String\>\]: key: id of extensionProperty
  \[GroupId \<String\>\]: key: id of group
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[OnPremisesAgentGroupId \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentGroupId1 \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentId \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesAgentId1 \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesPublishingProfileId \<String\>\]: key: id of onPremisesPublishingProfile
  \[PublishedResourceId \<String\>\]: key: id of publishedResource
  \[PublishedResourceId1 \<String\>\]: key: id of publishedResource
  \[ServicePrincipalId \<String\>\]: key: id of servicePrincipal
  \[SynchronizationJobId \<String\>\]: key: id of synchronizationJob
  \[SynchronizationTemplateId \<String\>\]: key: id of synchronizationTemplate
  \[UserId \<String\>\]: key: id of user

OBJECTS \<IMicrosoftGraphObjectDefinition\[\]\>: .
  \[Attributes \<IMicrosoftGraphAttributeDefinition\[\]\>\]: 
    \[Anchor \<Boolean?\>\]: 
    \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
      \[Key \<String\>\]: 
      \[Value \<String\>\]: 
    \[CaseExact \<Boolean?\>\]: 
    \[DefaultValue \<String\>\]: 
    \[FlowNullValues \<Boolean?\>\]: 
    \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
      \[Key \<String\>\]: 
      \[Value \<String\>\]: 
    \[Multivalued \<Boolean?\>\]: 
    \[Mutability \<String\>\]: mutability
    \[Name \<String\>\]: 
    \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
      \[ReferencedObjectName \<String\>\]: 
      \[ReferencedProperty \<String\>\]: 
    \[Required \<Boolean?\>\]: 
    \[Type \<String\>\]: attributeType
  \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
  \[Name \<String\>\]: 
  \[SupportedApis \<String\[\]\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationsynchronizationtemplateschemadirectory](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationsynchronizationtemplateschemadirectory)

