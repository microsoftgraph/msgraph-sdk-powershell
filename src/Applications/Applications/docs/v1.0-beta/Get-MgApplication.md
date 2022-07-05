---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/get-mgapplication
schema: 2.0.0
---

# Get-MgApplication

## SYNOPSIS
Get application

## SYNTAX

### List (Default)
```
Get-MgApplication [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>] [-Search <String>]
 [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-ConsistencyLevel <String>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgApplication -ApplicationId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgApplication -InputObject <IApplicationsIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get application

## EXAMPLES

### Example 1: Get a list of applications
```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

Id              : 8ea936e0-cb74-46c0-8408-d4614a596267
DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : Contoso.com
```

This examples gets a list of all the applications.

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`.
For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 2: Get an application by Id
```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -Filter "AppId eq '39b09640-ec3e-44c9-b3de-f52db4e1cf66'" | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : Contoso.com
```

This examples gets the application by the specified Id.

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`.
For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 3: Get a count of all applications
```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -ConsistencyLevel eventual -Count appCount

Id                                   DisplayName        AppId                                SignInAudience                     PublisherDomain
--                                   -----------        -----                                --------------                     ---------------
4f6f867b-4c34-44b2-9680-fe49d024ce74 New apps           bb6e3bbc-8048-412e-a55f-a6bbd8bac525 AzureADandPersonalMicrosoftAccount Contoso.com
bce20771-2a69-41e5-a0dd-125ac2fa2708 Example 3 App      ffdf268a-2fe2-49e1-8cd7-66ecb61641ec AzureADandPersonalMicrosoftAccount Contoso.com
dcaa0c3a-8dfa-4b47-bc04-0edbab42043a Principal-Test App bd38ad43-6c46-4cc6-b65c-a0db533a2a6f AzureADMyOrg                       Contoso.com
f6b30057-7095-4e2c-89f8-224149f591b7 Testing App        00e80963-9bc0-4147-b9e0-2ba56093e7e6 AzureADandPersonalMicrosoftAccount Contoso.com
fe4caed6-6182-4aca-b70b-b114c5334a8a New app            641992e9-d176-4aff-a3b6-a867b3ba48c4 AzureADandPersonalMicrosoftAccount Contoso.com
```

This example gets a list of all applications.
The $appCount variable contains the count of the objects in the result.
Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command.
For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`.
For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 4: Use -Search to get all the applications whose display name contains 'Test' including a count of the returned users
```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -ConsistencyLevel eventual -Count appCount -Search '"DisplayName:Test"'

Id                                   DisplayName        AppId                                SignInAudience                     PublisherDomain
--                                   -----------        -----                                --------------                     ---------------
dcaa0c3a-8dfa-4b47-bc04-0edbab42043a Principal-Test App bd38ad43-6c46-4cc6-b65c-a0db533a2a6f AzureADMyOrg                       Contoso.com
f6b30057-7095-4e2c-89f8-224149f591b7 Testing App        00e80963-9bc0-4147-b9e0-2ba56093e7e6 AzureADandPersonalMicrosoftAccount Contoso.com
```

This example returns all applications whose display name contains 'Test'.
The $appCount variable contains the count of the objects in the result.
Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command.
For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`.
For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 5: Use -Filter to get all the applications with a display name that starts with 'New' including a count of the returned users, with the results ordered by display name
```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -ConsistencyLevel eventual -Count appCount -Filter "startsWith(DisplayName, 'New')" -OrderBy DisplayName

Id                                   DisplayName AppId                                SignInAudience                     PublisherDomain
--                                   ----------- -----                                --------------                     ---------------
fe4caed6-6182-4aca-b70b-b114c5334a8a New app     641992e9-d176-4aff-a3b6-a867b3ba48c4 AzureADandPersonalMicrosoftAccount Contoso.com
0672d487-4c0c-475a-bf22-0e714f015597 New apps    ced14895-14ac-4dcf-8b93-0779f60c000d AzureADandPersonalMicrosoftAccount Contoso.com
```

This example returns all applications whose display name starts with 'New'.
The $appCount variable contains the count of the objects in the result.
Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command.
For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`.
For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

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
key: id of application

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication

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

