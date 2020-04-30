---
external help file:
Module Name: Microsoft.Graph.Identity.ServicePrincipal
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.serviceprincipal/get-mgserviceprincipalpasswordsinglesignoncredentials
schema: 2.0.0
---

# Get-MgServicePrincipalPasswordSingleSignOnCredentials

## SYNOPSIS
Invoke action getPasswordSingleSignOnCredentials

## SYNTAX

### GetExpanded (Default)
```
Get-MgServicePrincipalPasswordSingleSignOnCredentials -ServicePrincipalId <String> [-Id <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgServicePrincipalPasswordSingleSignOnCredentials -ServicePrincipalId <String>
 -BodyParameter <IPathsY2DqcyServiceprincipalsServiceprincipalIdMicrosoftGraphGetpasswordsinglesignoncredentialsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgServicePrincipalPasswordSingleSignOnCredentials -InputObject <IIdentityServicePrincipalIdentity>
 -BodyParameter <IPathsY2DqcyServiceprincipalsServiceprincipalIdMicrosoftGraphGetpasswordsinglesignoncredentialsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded
```
Get-MgServicePrincipalPasswordSingleSignOnCredentials -InputObject <IIdentityServicePrincipalIdentity>
 [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getPasswordSingleSignOnCredentials

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
Type: Microsoft.Graph.PowerShell.Models.IPathsY2DqcyServiceprincipalsServiceprincipalIdMicrosoftGraphGetpasswordsinglesignoncredentialsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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
Parameter Sets: GetViaIdentity, GetViaIdentityExpanded
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
Parameter Sets: Get, GetExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IPathsY2DqcyServiceprincipalsServiceprincipalIdMicrosoftGraphGetpasswordsinglesignoncredentialsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordSingleSignOnCredentialSet

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPathsY2DqcyServiceprincipalsServiceprincipalIdMicrosoftGraphGetpasswordsinglesignoncredentialsPostRequestbodyContentApplicationJsonSchema>: .
  - `[Id <String>]`: 

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

## RELATED LINKS

