---
external help file:
Module Name: Microsoft.Graph.Identity.ServicePrincipal
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.serviceprincipal/restart-mgserviceprincipalsynchronizationjob
schema: 2.0.0
---

# Restart-MgServicePrincipalSynchronizationJob

## SYNOPSIS
Invoke action restart

## SYNTAX

### RestartExpanded (Default)
```
Restart-MgServicePrincipalSynchronizationJob -ServicePrincipalId <String> -SynchronizationJobId <String>
 [-CriterionResetScope <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Restart
```
Restart-MgServicePrincipalSynchronizationJob -ServicePrincipalId <String> -SynchronizationJobId <String>
 -BodyParameter <IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestartViaIdentity
```
Restart-MgServicePrincipalSynchronizationJob -InputObject <IIdentityServicePrincipalIdentity>
 -BodyParameter <IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestartViaIdentityExpanded
```
Restart-MgServicePrincipalSynchronizationJob -InputObject <IIdentityServicePrincipalIdentity>
 [-CriterionResetScope <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action restart

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
Type: Microsoft.Graph.PowerShell.Models.IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Restart, RestartViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CriterionResetScope
synchronizationJobRestartScope

```yaml
Type: System.String
Parameter Sets: RestartExpanded, RestartViaIdentityExpanded
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
Parameter Sets: RestartViaIdentity, RestartViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -ServicePrincipalId
key: servicePrincipal-id of servicePrincipal

```yaml
Type: System.String
Parameter Sets: Restart, RestartExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SynchronizationJobId
key: synchronizationJob-id of synchronizationJob

```yaml
Type: System.String
Parameter Sets: Restart, RestartExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>: .
  - `[CriterionResetScope <String>]`: synchronizationJobRestartScope

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

