---
external help file:
Module Name: Microsoft.Graph.Identity.Application
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.application/invoke-mgparseapplicationsynchronizationjobschemaexpression
schema: 2.0.0
---

# Invoke-MgParseApplicationSynchronizationJobSchemaExpression

## SYNOPSIS
Invoke action parseExpression

## SYNTAX

### ParseExpanded (Default)
```
Invoke-MgParseApplicationSynchronizationJobSchemaExpression -ApplicationId <String>
 -SynchronizationJobId <String> [-DefinitionAttributes <IMicrosoftGraphAttributeDefinition[]>]
 [-DefinitionMetadata <IMicrosoftGraphMetadataEntry[]>] [-DefinitionName <String>]
 [-DefinitionSupportedApis <String[]>] [-Expression <String>] [-TargetAttributeDefinitionAnchor]
 [-TargetAttributeDefinitionApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]
 [-TargetAttributeDefinitionCaseExact] [-TargetAttributeDefinitionDefaultValue <String>]
 [-TargetAttributeDefinitionMetadata <IMicrosoftGraphMetadataEntry[]>] [-TargetAttributeDefinitionMultivalued]
 [-TargetAttributeDefinitionMutability <String>] [-TargetAttributeDefinitionName <String>]
 [-TargetAttributeDefinitionReferencedObjects <IMicrosoftGraphReferencedObject[]>]
 [-TargetAttributeDefinitionRequired] [-TargetAttributeDefinitionType <String>]
 [-TestInputObjectProperties <IMicrosoftGraphStringKeyObjectValuePair[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Parse
```
Invoke-MgParseApplicationSynchronizationJobSchemaExpression -ApplicationId <String>
 -SynchronizationJobId <String>
 -BodyParameter <IPaths14L6Pq1ApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ParseViaIdentity
```
Invoke-MgParseApplicationSynchronizationJobSchemaExpression -InputObject <IIdentityApplicationIdentity>
 -BodyParameter <IPaths14L6Pq1ApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ParseViaIdentityExpanded
```
Invoke-MgParseApplicationSynchronizationJobSchemaExpression -InputObject <IIdentityApplicationIdentity>
 [-DefinitionAttributes <IMicrosoftGraphAttributeDefinition[]>]
 [-DefinitionMetadata <IMicrosoftGraphMetadataEntry[]>] [-DefinitionName <String>]
 [-DefinitionSupportedApis <String[]>] [-Expression <String>] [-TargetAttributeDefinitionAnchor]
 [-TargetAttributeDefinitionApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]
 [-TargetAttributeDefinitionCaseExact] [-TargetAttributeDefinitionDefaultValue <String>]
 [-TargetAttributeDefinitionMetadata <IMicrosoftGraphMetadataEntry[]>] [-TargetAttributeDefinitionMultivalued]
 [-TargetAttributeDefinitionMutability <String>] [-TargetAttributeDefinitionName <String>]
 [-TargetAttributeDefinitionReferencedObjects <IMicrosoftGraphReferencedObject[]>]
 [-TargetAttributeDefinitionRequired] [-TargetAttributeDefinitionType <String>]
 [-TestInputObjectProperties <IMicrosoftGraphStringKeyObjectValuePair[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action parseExpression

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
Parameter Sets: Parse, ParseExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths14L6Pq1ApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Parse, ParseViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -DefinitionAttributes
.
To construct, see NOTES section for DEFINITIONATTRIBUTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeDefinition[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefinitionMetadata
.
To construct, see NOTES section for DEFINITIONMETADATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMetadataEntry[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefinitionName
.

```yaml
Type: System.String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefinitionSupportedApis
.

```yaml
Type: System.String[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Expression
.

```yaml
Type: System.String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity
Parameter Sets: ParseViaIdentity, ParseViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -SynchronizationJobId
key: synchronizationJob-id of synchronizationJob

```yaml
Type: System.String
Parameter Sets: Parse, ParseExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionAnchor
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionApiExpressions
.
To construct, see NOTES section for TARGETATTRIBUTEDEFINITIONAPIEXPRESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphStringKeyStringValuePair[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionCaseExact
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionDefaultValue
.

```yaml
Type: System.String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionMetadata
.
To construct, see NOTES section for TARGETATTRIBUTEDEFINITIONMETADATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMetadataEntry[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionMultivalued
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionMutability
mutability

```yaml
Type: System.String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionName
.

```yaml
Type: System.String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionReferencedObjects
.
To construct, see NOTES section for TARGETATTRIBUTEDEFINITIONREFERENCEDOBJECTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReferencedObject[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionRequired
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetAttributeDefinitionType
attributeType

```yaml
Type: System.String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TestInputObjectProperties
.
To construct, see NOTES section for TESTINPUTOBJECTPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphStringKeyObjectValuePair[]
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity

### Microsoft.Graph.PowerShell.Models.IPaths14L6Pq1ApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParseExpressionResponse

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths14L6Pq1ApplicationsApplicationIdSynchronizationJobsSynchronizationjobIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>: .
  - `[DefinitionAttributes <IMicrosoftGraphAttributeDefinition[]>]`: 
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
  - `[DefinitionMetadata <IMicrosoftGraphMetadataEntry[]>]`: 
  - `[DefinitionName <String>]`: 
  - `[DefinitionSupportedApis <String[]>]`: 
  - `[Expression <String>]`: 
  - `[TargetAttributeDefinitionAnchor <Boolean?>]`: 
  - `[TargetAttributeDefinitionApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
  - `[TargetAttributeDefinitionCaseExact <Boolean?>]`: 
  - `[TargetAttributeDefinitionDefaultValue <String>]`: 
  - `[TargetAttributeDefinitionMetadata <IMicrosoftGraphMetadataEntry[]>]`: 
  - `[TargetAttributeDefinitionMultivalued <Boolean?>]`: 
  - `[TargetAttributeDefinitionMutability <String>]`: mutability
  - `[TargetAttributeDefinitionName <String>]`: 
  - `[TargetAttributeDefinitionReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
  - `[TargetAttributeDefinitionRequired <Boolean?>]`: 
  - `[TargetAttributeDefinitionType <String>]`: attributeType
  - `[TestInputObjectProperties <IMicrosoftGraphStringKeyObjectValuePair[]>]`: 
    - `[Key <String>]`: 

#### DEFINITIONATTRIBUTES <IMicrosoftGraphAttributeDefinition[]>: .
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

#### DEFINITIONMETADATA <IMicrosoftGraphMetadataEntry[]>: .
  - `[Key <String>]`: 
  - `[Value <String>]`: 

#### INPUTOBJECT <IIdentityApplicationIdentity>: Identity Parameter
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

#### TARGETATTRIBUTEDEFINITIONAPIEXPRESSIONS <IMicrosoftGraphStringKeyStringValuePair[]>: .
  - `[Key <String>]`: 
  - `[Value <String>]`: 

#### TARGETATTRIBUTEDEFINITIONMETADATA <IMicrosoftGraphMetadataEntry[]>: .
  - `[Key <String>]`: 
  - `[Value <String>]`: 

#### TARGETATTRIBUTEDEFINITIONREFERENCEDOBJECTS <IMicrosoftGraphReferencedObject[]>: .
  - `[ReferencedObjectName <String>]`: 
  - `[ReferencedProperty <String>]`: 

#### TESTINPUTOBJECTPROPERTIES <IMicrosoftGraphStringKeyObjectValuePair[]>: .
  - `[Key <String>]`: 

## RELATED LINKS

