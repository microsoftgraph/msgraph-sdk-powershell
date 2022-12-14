---
external help file:
Module Name: Microsoft.Graph.Beta.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.applications/add-mgserviceprincipaltokensigningcertificate
schema: 2.0.0
---

# Add-MgBetaServicePrincipalTokenSigningCertificate

## SYNOPSIS
Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate.
The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: \n+ The keyCredentials object with the following objects:\n    + A private key object with **usage** set to `Sign`.\n    + A public key object with **usage** set to `Verify`.\n+ The passwordCredentials object.
All the objects have the same value of **customKeyIdentifier**.
The **passwordCredential** is used to open the PFX file (private key).
It and the associated private key object have the same value of **keyId**.
Once set during creation through the **displayName** property, the subject of the certificate cannot be updated.
The **startDateTime** is set to the same time the certificate is created using the action.
The **endDateTime** can be up to three years after the certificate is created.

## SYNTAX

### AddExpanded (Default)
```
Add-MgBetaServicePrincipalTokenSigningCertificate -ServicePrincipalId <String> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-EndDateTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add
```
Add-MgBetaServicePrincipalTokenSigningCertificate -ServicePrincipalId <String>
 -BodyParameter <IPathsEyijssServiceprincipalsServiceprincipalIdMicrosoftGraphAddtokensigningcertificatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentity
```
Add-MgBetaServicePrincipalTokenSigningCertificate -InputObject <IApplicationsIdentity>
 -BodyParameter <IPathsEyijssServiceprincipalsServiceprincipalIdMicrosoftGraphAddtokensigningcertificatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentityExpanded
```
Add-MgBetaServicePrincipalTokenSigningCertificate -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-EndDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate.
The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: \n+ The keyCredentials object with the following objects:\n    + A private key object with **usage** set to `Sign`.\n    + A public key object with **usage** set to `Verify`.\n+ The passwordCredentials object.
All the objects have the same value of **customKeyIdentifier**.
The **passwordCredential** is used to open the PFX file (private key).
It and the associated private key object have the same value of **keyId**.
Once set during creation through the **displayName** property, the subject of the certificate cannot be updated.
The **startDateTime** is set to the same time the certificate is created using the action.
The **endDateTime** can be up to three years after the certificate is created.

## EXAMPLES

### Example 1: Using the Add-MgBetaServicePrincipalTokenSigningCertificate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	DisplayName = "CN=customDisplayName"
	EndDateTime = [System.DateTime]::Parse("2024-01-25T00:00:00Z")
}
Add-MgBetaServicePrincipalTokenSigningCertificate -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```

This example shows how to use the Add-MgBetaServicePrincipalTokenSigningCertificate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsEyijssServiceprincipalsServiceprincipalIdMicrosoftGraphAddtokensigningcertificatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: AddExpanded, AddViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity
Parameter Sets: AddViaIdentity, AddViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: System.String
Parameter Sets: Add, AddExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPathsEyijssServiceprincipalsServiceprincipalIdMicrosoftGraphAddtokensigningcertificatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSelfSignedCertificate

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsEyijssServiceprincipalsServiceprincipalIdMicrosoftGraphAddtokensigningcertificatePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: key: id of federatedIdentityCredential
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

