---
external help file:
Module Name: Microsoft.Graph.Beta.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.applications/new-mgbetagroupapproleassignment
schema: 2.0.0
---

# New-MgBetaGroupAppRoleAssignment

## SYNOPSIS
Use this API to assign an app role to a security group.
All direct members of the group will be considered assigned.
Security groups with dynamic memberships are supported.
To grant an app role assignment to a group, you need three identifiers: Additional licenses might be required to use a group to manage access to applications.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaGroupAppRoleAssignment -GroupId <String> [-AdditionalProperties <Hashtable>] [-AppRoleId <String>]
 [-CreationTimestamp <DateTime>] [-Id <String>] [-PrincipalDisplayName <String>] [-PrincipalId <String>]
 [-PrincipalType <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaGroupAppRoleAssignment -GroupId <String> -BodyParameter <IMicrosoftGraphAppRoleAssignment>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaGroupAppRoleAssignment -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphAppRoleAssignment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaGroupAppRoleAssignment -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-AppRoleId <String>] [-CreationTimestamp <DateTime>] [-Id <String>] [-PrincipalDisplayName <String>]
 [-PrincipalId <String>] [-PrincipalType <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Use this API to assign an app role to a security group.
All direct members of the group will be considered assigned.
Security groups with dynamic memberships are supported.
To grant an app role assignment to a group, you need three identifiers: Additional licenses might be required to use a group to manage access to applications.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
$appRoleAssignment = @{
  "principalId"= "f07a8d78-f18c-4c02-b339-9ebace025122"
  "resourceId"= "1c48f923-4fbb-4d37-b772-4d577eefec9e"
  "appRoleId"= "00000000-0000-0000-0000-000000000000"
  }
```

New-MgBetaGroupAppRoleAssignment -GroupId 'f07a8d78-f18c-4c02-b339-9ebace025122' -BodyParameter $appRoleAssignment | 
  Format-List

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/19/2021 11:25:25 AM
DeletedDateTime      :
Id                   : eI168IzxAkyzOZ66zgJRIqVVeeA1CVFKmaBn-MgBetan0Bw
PrincipalDisplayName : All Employees
PrincipalId          : f07a8d78-f18c-4c02-b339-9ebace025122
PrincipalType        : Group
ResourceDisplayName  : Office 365 SharePoint Online
ResourceId           : 1c48f923-4fbb-4d37-b772-4d577eefec9e
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#groups('f07a8d78-f18c-4c02-b339-9ebace025122')/appRoleAssignments/$entity], [@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-
                       b10d-14f1195d665f/directoryObjects/$/Microsoft.DirectoryServices.Group('f07a8d78-f18c-4c02-b339-9ebace025122')/appRoleAssignments/eI168IzxAkyzOZ66zgJRIqVVeeA1CVFKmaBn-MgBetan0Bw]}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoleId
The identifier (id) for the app role which is assigned to the principal.
This app role must be exposed in the appRoles property on the resource application's service principal (resourceId).
If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles.
Required on create.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
appRoleAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppRoleAssignment
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreationTimestamp
The time when the app role assignment was created.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PrincipalDisplayName
The display name of the user, group, or service principal that was granted the app role assignment.
Read-only.
Supports $filter (eq and startswith).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrincipalId
The unique identifier (id) for the user, security group, or service principal being granted the app role.
Security groups with dynamic memberships are supported.
Required on create.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrincipalType
The type of the assigned principal.
This can either be User, Group, or ServicePrincipal.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceDisplayName
The display name of the resource app's service principal to which the assignment is made.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
The unique identifier (id) for the resource service principal for which the assignment is made.
Required on create.
Supports $filter (eq only).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppRoleAssignment

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppRoleAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAppRoleAssignment>`: appRoleAssignment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppRoleId <String>]`: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
  - `[CreationTimestamp <DateTime?>]`: The time when the app role assignment was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[PrincipalDisplayName <String>]`: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
  - `[PrincipalId <String>]`: The unique identifier (id) for the user, security group, or service principal being granted the app role. Security groups with dynamic memberships are supported. Required on create.
  - `[PrincipalType <String>]`: The type of the assigned principal. This can either be User, Group, or ServicePrincipal. Read-only.
  - `[ResourceDisplayName <String>]`: The display name of the resource app's service principal to which the assignment is made.
  - `[ResourceId <String>]`: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).

`INPUTOBJECT <IApplicationsIdentity>`: Identity Parameter
  - `[AppId <String>]`: Alternate key of application
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
  - `[Name <String>]`: Alternate key of federatedIdentityCredential
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: The unique identifier of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: The unique identifier of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: The unique identifier of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: The unique identifier of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: The unique identifier of publishedResource
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[SynchronizationJobId <String>]`: The unique identifier of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: The unique identifier of synchronizationTemplate
  - `[TargetDeviceGroupId <String>]`: The unique identifier of targetDeviceGroup
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UniqueName <String>]`: Alternate key of application
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

