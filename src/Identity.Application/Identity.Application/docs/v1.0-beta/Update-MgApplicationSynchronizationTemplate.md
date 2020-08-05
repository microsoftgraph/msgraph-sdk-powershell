---
external help file:
Module Name: Microsoft.Graph.Identity.Application
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.application/update-mgapplicationsynchronizationtemplate
schema: 2.0.0
---

# Update-MgApplicationSynchronizationTemplate

## SYNOPSIS
Update the navigation property templates in applications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgApplicationSynchronizationTemplate -ApplicationId <String> -SynchronizationTemplateId <String>
 [-ApplicationId1 <String>] [-Default] [-Description <String>] [-Discoverable] [-FactoryTag <String>]
 [-Id <String>] [-Metadata <IMicrosoftGraphMetadataEntry[]>]
 [-SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>] [-SchemaId <String>]
 [-SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>] [-SchemaVersion <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgApplicationSynchronizationTemplate -ApplicationId <String> -SynchronizationTemplateId <String>
 -BodyParameter <IMicrosoftGraphSynchronizationTemplate> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgApplicationSynchronizationTemplate -InputObject <IIdentityApplicationIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationTemplate> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgApplicationSynchronizationTemplate -InputObject <IIdentityApplicationIdentity>
 [-ApplicationId <String>] [-Default] [-Description <String>] [-Discoverable] [-FactoryTag <String>]
 [-Id <String>] [-Metadata <IMicrosoftGraphMetadataEntry[]>]
 [-SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>] [-SchemaId <String>]
 [-SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>] [-SchemaVersion <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property templates in applications

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

### -ApplicationId
key: application-id of application

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationId1
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
synchronizationTemplate
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationTemplate
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Default
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

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

### -Discoverable
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FactoryTag
.

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
Type: Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Metadata
.
To construct, see NOTES section for METADATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMetadataEntry[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -SchemaDirectories
.
To construct, see NOTES section for SCHEMADIRECTORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryDefinition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchemaId
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

### -SchemaSynchronizationRules
.
To construct, see NOTES section for SCHEMASYNCHRONIZATIONRULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationRule[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchemaVersion
.

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

### -SynchronizationTemplateId
key: synchronizationTemplate-id of synchronizationTemplate

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

### Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationTemplate

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSynchronizationTemplate>: synchronizationTemplate
  - `[Id <String>]`: Read-only.
  - `[ApplicationId <String>]`: 
  - `[Default <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[Discoverable <Boolean?>]`: 
  - `[FactoryTag <String>]`: 
  - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Key <String>]`: 
    - `[Value <String>]`: 
  - `[SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
    - `[DiscoveryDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
        - `[Anchor <Boolean?>]`: 
        - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[Value <String>]`: 
        - `[CaseExact <Boolean?>]`: 
        - `[DefaultValue <String>]`: 
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Multivalued <Boolean?>]`: 
        - `[Mutability <String>]`: mutability
        - `[Name <String>]`: 
        - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
          - `[ReferencedObjectName <String>]`: 
          - `[ReferencedProperty <String>]`: 
        - `[Required <Boolean?>]`: 
        - `[Type <String>]`: attributeType
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Version <String>]`: 
  - `[SchemaId <String>]`: Read-only.
  - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
    - `[Editable <Boolean?>]`: 
    - `[Id <String>]`: 
    - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Name <String>]`: 
    - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
      - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
        - `[DefaultValue <String>]`: 
        - `[ExportMissingReferences <Boolean?>]`: 
        - `[FlowBehavior <String>]`: attributeFlowBehavior
        - `[FlowType <String>]`: attributeFlowType
        - `[MatchingPriority <Int32?>]`: 
        - `[SourceExpression <String>]`: 
        - `[SourceName <String>]`: 
        - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[ValueExpression <String>]`: 
          - `[ValueName <String>]`: 
          - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[ValueType <String>]`: attributeMappingSourceType
        - `[SourceType <String>]`: attributeMappingSourceType
        - `[TargetAttributeName <String>]`: 
      - `[Enabled <Boolean?>]`: 
      - `[FlowTypes <String>]`: objectFlowTypes
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
          - `[OperatorName <String>]`: 
          - `[SourceOperandName <String>]`: 
          - `[TargetOperandValues <String[]>]`: 
        - `[Name <String>]`: 
      - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[SourceObjectName <String>]`: 
      - `[TargetObjectName <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[SourceDirectoryName <String>]`: 
    - `[TargetDirectoryName <String>]`: 
  - `[SchemaVersion <String>]`: 

INPUTOBJECT <IIdentityApplicationIdentity>: Identity Parameter
  - `[ApplicationId <String>]`: key: application-id of application
  - `[ApplicationTemplateId <String>]`: key: applicationTemplate-id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: claimsMappingPolicy-id of claimsMappingPolicy
  - `[DirectoryDefinitionId <String>]`: key: directoryDefinition-id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionPropertyId <String>]`: key: extensionProperty-id of extensionProperty
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: homeRealmDiscoveryPolicy-id of homeRealmDiscoveryPolicy
  - `[SynchronizationJobId <String>]`: key: synchronizationJob-id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: synchronizationTemplate-id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: tokenIssuancePolicy-id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: tokenLifetimePolicy-id of tokenLifetimePolicy

METADATA <IMicrosoftGraphMetadataEntry[]>: .
  - `[Key <String>]`: 
  - `[Value <String>]`: 

SCHEMADIRECTORIES <IMicrosoftGraphDirectoryDefinition[]>: .
  - `[Id <String>]`: Read-only.
  - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
  - `[DiscoveryDateTime <DateTime?>]`: 
  - `[Name <String>]`: 
  - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
    - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
      - `[Anchor <Boolean?>]`: 
      - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
        - `[Key <String>]`: 
        - `[Value <String>]`: 
      - `[CaseExact <Boolean?>]`: 
      - `[DefaultValue <String>]`: 
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Key <String>]`: 
        - `[Value <String>]`: 
      - `[Multivalued <Boolean?>]`: 
      - `[Mutability <String>]`: mutability
      - `[Name <String>]`: 
      - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
        - `[ReferencedObjectName <String>]`: 
        - `[ReferencedProperty <String>]`: 
      - `[Required <Boolean?>]`: 
      - `[Type <String>]`: attributeType
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Name <String>]`: 
    - `[SupportedApis <String[]>]`: 
  - `[ReadOnly <Boolean?>]`: 
  - `[Version <String>]`: 

SCHEMASYNCHRONIZATIONRULES <IMicrosoftGraphSynchronizationRule[]>: .
  - `[Editable <Boolean?>]`: 
  - `[Id <String>]`: 
  - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Key <String>]`: 
    - `[Value <String>]`: 
  - `[Name <String>]`: 
  - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
    - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
      - `[DefaultValue <String>]`: 
      - `[ExportMissingReferences <Boolean?>]`: 
      - `[FlowBehavior <String>]`: attributeFlowBehavior
      - `[FlowType <String>]`: attributeFlowType
      - `[MatchingPriority <Int32?>]`: 
      - `[SourceExpression <String>]`: 
      - `[SourceName <String>]`: 
      - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
        - `[Key <String>]`: 
        - `[ValueExpression <String>]`: 
        - `[ValueName <String>]`: 
        - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
        - `[ValueType <String>]`: attributeMappingSourceType
      - `[SourceType <String>]`: attributeMappingSourceType
      - `[TargetAttributeName <String>]`: 
    - `[Enabled <Boolean?>]`: 
    - `[FlowTypes <String>]`: objectFlowTypes
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Key <String>]`: 
      - `[Value <String>]`: 
    - `[Name <String>]`: 
    - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
        - `[OperatorName <String>]`: 
        - `[SourceOperandName <String>]`: 
        - `[TargetOperandValues <String[]>]`: 
      - `[Name <String>]`: 
    - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
    - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
    - `[SourceObjectName <String>]`: 
    - `[TargetObjectName <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[SourceDirectoryName <String>]`: 
  - `[TargetDirectoryName <String>]`: 

## RELATED LINKS

