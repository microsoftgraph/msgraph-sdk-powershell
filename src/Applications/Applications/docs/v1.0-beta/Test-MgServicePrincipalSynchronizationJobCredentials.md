---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/test-mgserviceprincipalsynchronizationjobcredentials
schema: 2.0.0
---

# Test-MgServicePrincipalSynchronizationJobCredentials

## SYNOPSIS
Invoke action validateCredentials

## SYNTAX

### ValidateExpanded (Default)
```
Test-MgServicePrincipalSynchronizationJobCredentials -ServicePrincipalId <String>
 -SynchronizationJobId <String> [-AdditionalProperties <Hashtable>] [-ApplicationIdentifier <String>]
 [-Credentials <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>] [-TemplateId <String>]
 [-UseSavedCredentials] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Validate
```
Test-MgServicePrincipalSynchronizationJobCredentials -ServicePrincipalId <String>
 -SynchronizationJobId <String>
 -BodyParameter <IPaths3LjeyyServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphValidatecredentialsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ValidateViaIdentityExpanded
```
Test-MgServicePrincipalSynchronizationJobCredentials -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ApplicationIdentifier <String>]
 [-Credentials <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>] [-TemplateId <String>]
 [-UseSavedCredentials] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ValidateViaIdentity
```
Test-MgServicePrincipalSynchronizationJobCredentials -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths3LjeyyServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphValidatecredentialsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action validateCredentials

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationIdentifier
.

```yaml
Type: String
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPaths3LjeyyServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphValidatecredentialsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Validate, ValidateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Credentials
.
To construct, see NOTES section for CREDENTIALS properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
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
Parameter Sets: ValidateViaIdentityExpanded, ValidateViaIdentity
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

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: String
Parameter Sets: ValidateExpanded, Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationJobId
key: id of synchronizationJob

```yaml
Type: String
Parameter Sets: ValidateExpanded, Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateId
.

```yaml
Type: String
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseSavedCredentials
.

```yaml
Type: SwitchParameter
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths3LjeyyServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphValidatecredentialsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths3LjeyyServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphValidatecredentialsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApplicationIdentifier <String>]`: 
  - `[Credentials <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
    - `[Key <String>]`: synchronizationSecret
    - `[Value <String>]`: The value of the secret.
  - `[TemplateId <String>]`: 
  - `[UseSavedCredentials <Boolean?>]`: 

CREDENTIALS <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>: .
  - `[Key <String>]`: synchronizationSecret
  - `[Value <String>]`: The value of the secret.

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
