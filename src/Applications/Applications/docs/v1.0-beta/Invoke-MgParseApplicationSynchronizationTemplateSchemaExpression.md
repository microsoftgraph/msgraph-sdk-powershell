---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/invoke-mgparseapplicationsynchronizationtemplateschemaexpression
schema: 2.0.0
---

# Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression

## SYNOPSIS
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

## SYNTAX

### ParseExpanded (Default)
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -ApplicationId <String>
 -SynchronizationTemplateId <String> [-AdditionalProperties <Hashtable>] [-Expression <String>]
 [-TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]
 [-TestInputObject <IMicrosoftGraphExpressionInputObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Parse
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -ApplicationId <String>
 -SynchronizationTemplateId <String>
 -BodyParameter <IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ParseViaIdentity
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ParseViaIdentityExpanded
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Expression <String>]
 [-TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]
 [-TestInputObject <IMicrosoftGraphExpressionInputObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationId
The unique identifier of application

```yaml
Type: System.String
Parameter Sets: Parse, ParseExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Parse, ParseViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
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
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: ParseViaIdentity, ParseViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SynchronizationTemplateId
The unique identifier of synchronizationTemplate

```yaml
Type: System.String
Parameter Sets: Parse, ParseExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetAttributeDefinition
attributeDefinition
To construct, please use Get-Help -Online and see NOTES section for TARGETATTRIBUTEDEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeDefinition
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TestInputObject
expressionInputObject
To construct, please use Get-Help -Online and see NOTES section for TESTINPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExpressionInputObject
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParseExpressionResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Expression <String>]`: 
  - `[TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]`: attributeDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
    - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
      - `[Key <String>]`: Key.
      - `[Value <String>]`: Value.
    - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
    - `[DefaultValue <String>]`: 
    - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
      - `[Key <String>]`: Name of the metadata property.
      - `[Value <String>]`: Value of the metadata property.
    - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
    - `[Mutability <String>]`: mutability
    - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
    - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
      - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
      - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
    - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
    - `[Type <String>]`: attributeType
  - `[TestInputObject <IMicrosoftGraphExpressionInputObject>]`: expressionInputObject
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Definition <IMicrosoftGraphObjectDefinition>]`: objectDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[Properties <IMicrosoftGraphStringKeyObjectValuePair[]>]`: Property values of the test object.
      - `[Key <String>]`: Key.

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: The unique identifier of appRoleAssignment
  - `[ApplicationId <String>]`: The unique identifier of application
  - `[ApplicationTemplateId <String>]`: The unique identifier of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: The unique identifier of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: The unique identifier of connectorGroup
  - `[ConnectorId <String>]`: The unique identifier of connector
  - `[DelegatedPermissionClassificationId <String>]`: The unique identifier of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: The unique identifier of directoryDefinition
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndpointId <String>]`: The unique identifier of endpoint
  - `[ExtensionPropertyId <String>]`: The unique identifier of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: The unique identifier of federatedIdentityCredential
  - `[GroupId <String>]`: The unique identifier of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: The unique identifier of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: The unique identifier of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: The unique identifier of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: The unique identifier of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: The unique identifier of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: The unique identifier of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: The unique identifier of publishedResource
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[SynchronizationJobId <String>]`: The unique identifier of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: The unique identifier of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UserId <String>]`: The unique identifier of user

TARGETATTRIBUTEDEFINITION <IMicrosoftGraphAttributeDefinition>: attributeDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
  - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Key <String>]`: Key.
    - `[Value <String>]`: Value.
  - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
  - `[DefaultValue <String>]`: 
  - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
  - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
    - `[Key <String>]`: Name of the metadata property.
    - `[Value <String>]`: Value of the metadata property.
  - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
  - `[Mutability <String>]`: mutability
  - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
  - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
    - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
    - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
  - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
  - `[Type <String>]`: attributeType

TESTINPUTOBJECT <IMicrosoftGraphExpressionInputObject>: expressionInputObject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Definition <IMicrosoftGraphObjectDefinition>]`: objectDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
      - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
      - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
        - `[Key <String>]`: Key.
        - `[Value <String>]`: Value.
      - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
      - `[DefaultValue <String>]`: 
      - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
        - `[Key <String>]`: Name of the metadata property.
        - `[Value <String>]`: Value of the metadata property.
      - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
      - `[Mutability <String>]`: mutability
      - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
      - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
        - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
        - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
      - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
      - `[Type <String>]`: attributeType
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Name <String>]`: 
    - `[SupportedApis <String[]>]`: 
  - `[Properties <IMicrosoftGraphStringKeyObjectValuePair[]>]`: Property values of the test object.
    - `[Key <String>]`: Key.

## RELATED LINKS

