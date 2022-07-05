---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/get-mgserviceprincipalapproleassignment
schema: 2.0.0
---

# Get-MgServicePrincipalAppRoleAssignment

## SYNOPSIS
Get appRoleAssignments from servicePrincipals

## SYNTAX

### List (Default)
```
Get-MgServicePrincipalAppRoleAssignment -ServicePrincipalId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgServicePrincipalAppRoleAssignment -AppRoleAssignmentId <String> -ServicePrincipalId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgServicePrincipalAppRoleAssignment -InputObject <IApplicationsIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get appRoleAssignments from servicePrincipals

## EXAMPLES

### Example 1: Get all application role assignments for a service principal
```powershell
Get-MgServicePrincipalAppRoleAssignment -ServicePrincipalId '0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61' |  Format-List

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/31/2021 2:01:28 PM
DeletedDateTime      :
Id                   : PRLbC6e4yUyMwr0XutBvYfZHkKGzlbxDr2I-QJWN9rs
PrincipalDisplayName : Example App
PrincipalId          : 0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61
PrincipalType        : ServicePrincipal
ResourceDisplayName  : Office 365 Management APIs
ResourceId           : 557aedfc-007c-4904-918a-7e6fed2e7403
AdditionalProperties : {[@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-b10d-14f1195d665f/directoryObjects/$/Microsof
                       t.DirectoryServices.ServicePrincipal('0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61')/appRoleAssignments/PRLbC6e4yUyM
                       wr0XutBvYfZHkKGzlbxDr2I-QJWN9rs]}

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/31/2021 1:59:44 PM
DeletedDateTime      :
Id                   : PRLbC6e4yUyMwr0XutBvYZsr7FiAW3pIqP4F9944yBc
PrincipalDisplayName : Example App
PrincipalId          : 0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61
PrincipalType        : ServicePrincipal
ResourceDisplayName  : Office 365 SharePoint Online
ResourceId           : 1c48f923-4fbb-4d37-b772-4d577eefec9e
AdditionalProperties : {[@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-b10d-14f1195d665f/directoryObjects/$/Microsof
                       t.DirectoryServices.ServicePrincipal('0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61')/appRoleAssignments/PRLbC6e4yUyM
                       wr0XutBvYZsr7FiAW3pIqP4F9944yBc]}
```

This example gets the application role assignments that have been granted to the specified service principal.

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoleAssignmentId
key: id of appRoleAssignment

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
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
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Limit

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

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

