---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgapplicationfederatedidentitycredential
schema: 2.0.0
---

# Update-MgApplicationFederatedIdentityCredential

## SYNOPSIS
Update the navigation property federatedIdentityCredentials in applications

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgApplicationFederatedIdentityCredential -ApplicationId <String>
 -FederatedIdentityCredentialId <String> [-AdditionalProperties <Hashtable>] [-Audiences <String[]>]
 [-Description <String>] [-Id <String>] [-Issuer <String>] [-Name <String>] [-Subject <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgApplicationFederatedIdentityCredential -ApplicationId <String>
 -FederatedIdentityCredentialId <String> -BodyParameter <IMicrosoftGraphFederatedIdentityCredential>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgApplicationFederatedIdentityCredential -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphFederatedIdentityCredential> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgApplicationFederatedIdentityCredential -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Audiences <String[]>] [-Description <String>] [-Id <String>]
 [-Issuer <String>] [-Name <String>] [-Subject <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property federatedIdentityCredentials in applications

## EXAMPLES

### Example 1: Using the Update-MgApplicationFederatedIdentityCredential Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Name = "testing02"
	Issuer = "https://login.microsoftonline.com/3d1e2be9-a10a-4a0c-8380-7ce190f98ed9/v2.0"
	Subject = "a7d388c3-5e3f-4959-ac7d-786b3383006a"
	Description = "Updated description"
	Audiences = @(
		"api://AzureADTokenExchange"
	)
}
Update-MgApplicationFederatedIdentityCredential -ApplicationId $applicationId -FederatedIdentityCredentialId $federatedIdentityCredentialId -BodyParameter $params
```

This example shows how to use the Update-MgApplicationFederatedIdentityCredential Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Audiences
The audience that can appear in the external token.
This field is mandatory and should be set to api://AzureADTokenExchange for Azure AD.
It says what Microsoft identity platform should accept in the aud claim in the incoming token.
This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token.
This field can only accept a single value and has a limit of 600 characters.
Required.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
federatedIdentityCredential
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFederatedIdentityCredential
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
The un-validated, user-provided description of the federated identity credential.
It has a limit of 600 characters.
Optional.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FederatedIdentityCredentialId
The unique identifier of federatedIdentityCredential

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Issuer
The URL of the external identity provider and must match the issuer claim of the external token being exchanged.
The combination of the values of issuer and subject must be unique on the app.
It has a limit of 600 characters.
Required.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
is the unique identifier for the federated identity credential, which has a limit of 120 characters and must be URL friendly.
It is immutable once created.
Required.
Not nullable.
Supports $filter (eq).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -Subject
Required.
The identifier of the external software workload within the external identity provider.
Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings.
The value here must match the sub claim within the token presented to Azure AD.
The combination of issuer and subject must be unique on the app.
It has a limit of 600 characters.
Supports $filter (eq).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFederatedIdentityCredential

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphFederatedIdentityCredential>: federatedIdentityCredential
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Audiences <String[]>]`: The audience that can appear in the external token. This field is mandatory and should be set to api://AzureADTokenExchange for Azure AD. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. This field can only accept a single value and has a limit of 600 characters. Required.
  - `[Description <String>]`: The un-validated, user-provided description of the federated identity credential. It has a limit of 600 characters. Optional.
  - `[Issuer <String>]`: The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. It has a limit of 600 characters. Required.
  - `[Name <String>]`: is the unique identifier for the federated identity credential, which has a limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).
  - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. It has a limit of 600 characters. Supports $filter (eq).

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

## RELATED LINKS

