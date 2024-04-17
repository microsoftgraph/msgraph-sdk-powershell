---
external help file:
Module Name: Microsoft.Graph.Beta.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.applications/get-mgbetaapplication
schema: 2.0.0
---

# Get-MgBetaApplication

## SYNOPSIS
Get the properties and relationships of an application object.

## SYNTAX

### List (Default)
```
Get-MgBetaApplication [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>]
 [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-ConsistencyLevel <String>]
 [-ResponseHeadersVariable <String>] [-All] [-CountVariable <String>] [-Headers <IDictionary>]
 [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgBetaApplication -ApplicationId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaApplication -InputObject <IApplicationsIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [<CommonParameters>]
```

## DESCRIPTION
Get the properties and relationships of an application object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaApplication | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain
```

Id              : 8ea936e0-cb74-46c0-8408-d4614a596267
DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : Contoso.com

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaApplication -Filter "AppId eq '39b09640-ec3e-44c9-b3de-f52db4e1cf66'" | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain
```

DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : Contoso.com

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaApplication -ConsistencyLevel eventual -Count appCount
```

Id                                   DisplayName        AppId                                SignInAudience                     PublisherDomain
--                                   -----------        -----                                --------------                     ---------------
4f6f867b-4c34-44b2-9680-fe49d024ce74 New apps           bb6e3bbc-8048-412e-a55f-a6bbd8bac525 AzureADandPersonalMicrosoftAccount Contoso.com
bce20771-2a69-41e5-a0dd-125ac2fa2708 Example 3 App      ffdf268a-2fe2-49e1-8cd7-66ecb61641ec AzureADandPersonalMicrosoftAccount Contoso.com
dcaa0c3a-8dfa-4b47-bc04-0edbab42043a Principal-Test App bd38ad43-6c46-4cc6-b65c-a0db533a2a6f AzureADMyOrg                       Contoso.com
f6b30057-7095-4e2c-89f8-224149f591b7 Testing App        00e80963-9bc0-4147-b9e0-2ba56093e7e6 AzureADandPersonalMicrosoftAccount Contoso.com
fe4caed6-6182-4aca-b70b-b114c5334a8a New app            641992e9-d176-4aff-a3b6-a867b3ba48c4 AzureADandPersonalMicrosoftAccount Contoso.com

### -------------------------- EXAMPLE 4 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaApplication -ConsistencyLevel eventual -Count appCount -Search '"DisplayName:Test"'
```

Id                                   DisplayName        AppId                                SignInAudience                     PublisherDomain
--                                   -----------        -----                                --------------                     ---------------
dcaa0c3a-8dfa-4b47-bc04-0edbab42043a Principal-Test App bd38ad43-6c46-4cc6-b65c-a0db533a2a6f AzureADMyOrg                       Contoso.com
f6b30057-7095-4e2c-89f8-224149f591b7 Testing App        00e80963-9bc0-4147-b9e0-2ba56093e7e6 AzureADandPersonalMicrosoftAccount Contoso.com

### -------------------------- EXAMPLE 5 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaApplication -ConsistencyLevel eventual -Count appCount -Filter "startsWith(DisplayName, 'New')" -OrderBy DisplayName
```

Id                                   DisplayName AppId                                SignInAudience                     PublisherDomain
--                                   ----------- -----                                --------------                     ---------------
fe4caed6-6182-4aca-b70b-b114c5334a8a New app     641992e9-d176-4aff-a3b6-a867b3ba48c4 AzureADandPersonalMicrosoftAccount Contoso.com
0672d487-4c0c-475a-bf22-0e714f015597 New apps    ced14895-14ac-4dcf-8b93-0779f60c000d AzureADandPersonalMicrosoftAccount Contoso.com

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

### -ApplicationId
The unique identifier of application

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

### -ConsistencyLevel
Indicates the requested consistency level.
Documentation URL: https://docs.microsoft.com/graph/aad-advanced-queries

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity
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

### Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphApplication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

