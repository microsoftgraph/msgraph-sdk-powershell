---
external help file:
Module Name: Microsoft.Graph.Identity.ServicePrincipal
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.serviceprincipal/invoke-mgparseserviceprincipalsynchronizationtemplateschemaexpression
schema: 2.0.0
---

# Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression

## SYNOPSIS
Invoke action parseExpression

## SYNTAX

### ParseExpanded (Default)
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression -ServicePrincipalId <String>
 -SynchronizationTemplateId <String> [-DefinitionAttributes <IMicrosoftGraphAttributeDefinition[]>]
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
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression -ServicePrincipalId <String>
 -SynchronizationTemplateId <String>
 -BodyParameter <IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ParseViaIdentity
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression
 -InputObject <IIdentityServicePrincipalIdentity>
 -BodyParameter <IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ParseViaIdentityExpanded
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression
 -InputObject <IIdentityServicePrincipalIdentity>
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

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityServicePrincipalIdentity
Parameter Sets: ParseViaIdentity, ParseViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ServicePrincipalId
key: servicePrincipal-id of servicePrincipal

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

### -SynchronizationTemplateId
key: synchronizationTemplate-id of synchronizationTemplate

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

### Microsoft.Graph.PowerShell.Models.IIdentityServicePrincipalIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParseExpressionResponse

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>: .
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

#### INPUTOBJECT <IIdentityServicePrincipalIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: appRoleAssignment-id of appRoleAssignment
  - `[ClaimsMappingPolicyId <String>]`: key: claimsMappingPolicy-id of claimsMappingPolicy
  - `[DirectoryDefinitionId <String>]`: key: directoryDefinition-id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[EndpointId <String>]`: key: endpoint-id of endpoint
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: homeRealmDiscoveryPolicy-id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: licenseDetails-id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: oAuth2PermissionGrant-id of oAuth2PermissionGrant
  - `[ServicePrincipalId <String>]`: key: servicePrincipal-id of servicePrincipal
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

