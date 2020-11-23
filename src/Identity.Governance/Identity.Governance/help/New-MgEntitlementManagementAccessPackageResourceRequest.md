---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresourcerequest
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackageResourceRequest

## SYNOPSIS
Create new navigation property to accessPackageResourceRequests for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementAccessPackageResourceRequest
 [-AccessPackageResource <IMicrosoftGraphAccessPackageResource>] [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-ExecuteImmediately] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-IsValidationOnly] [-Justification <String>] [-RequestState <String>] [-RequestStatus <String>]
 [-RequestType <String>] [-Requestor <IMicrosoftGraphAccessPackageSubject>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementAccessPackageResourceRequest
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRequest> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to accessPackageResourceRequests for identityGovernance

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AccessPackageResource
accessPackageResource
To construct, see NOTES section for ACCESSPACKAGERESOURCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResource
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageResourceRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogId
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExecuteImmediately
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsValidationOnly
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Justification
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Requestor
accessPackageSubject
To construct, see NOTES section for REQUESTOR properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageSubject
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestState
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestStatus
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestType
.

```yaml
Type: String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSPACKAGERESOURCE \<IMicrosoftGraphAccessPackageResource\>: accessPackageResource
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
  \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsRootScope \<Boolean?\>\]: 
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
    \[RoleOriginId \<String\>\]: 
    \[Url \<String\>\]: 
  \[AddedBy \<String\>\]: 
  \[AddedOn \<DateTime?\>\]: 
  \[Attributes \<IMicrosoftGraphAccessPackageResourceAttribute\[\]\>\]: 
    \[AttributeDestination \<IMicrosoftGraphAccessPackageResourceAttributeDestination\>\]: accessPackageResourceAttributeDestination
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AttributeName \<String\>\]: 
    \[AttributeSource \<IMicrosoftGraphAccessPackageResourceAttributeSource\>\]: accessPackageResourceAttributeSource
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsPendingOnboarding \<Boolean?\>\]: 
  \[OriginId \<String\>\]: 
  \[OriginSystem \<String\>\]: 
  \[ResourceType \<String\>\]: 
  \[Url \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphAccessPackageResourceRequest\>: accessPackageResourceRequest
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[OriginId \<String\>\]: 
      \[OriginSystem \<String\>\]: 
    \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[IsRootScope \<Boolean?\>\]: 
      \[OriginId \<String\>\]: 
      \[OriginSystem \<String\>\]: 
      \[RoleOriginId \<String\>\]: 
      \[Url \<String\>\]: 
    \[AddedBy \<String\>\]: 
    \[AddedOn \<DateTime?\>\]: 
    \[Attributes \<IMicrosoftGraphAccessPackageResourceAttribute\[\]\>\]: 
      \[AttributeDestination \<IMicrosoftGraphAccessPackageResourceAttributeDestination\>\]: accessPackageResourceAttributeDestination
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AttributeName \<String\>\]: 
      \[AttributeSource \<IMicrosoftGraphAccessPackageResourceAttributeSource\>\]: accessPackageResourceAttributeSource
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsPendingOnboarding \<Boolean?\>\]: 
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
    \[ResourceType \<String\>\]: 
    \[Url \<String\>\]: 
  \[CatalogId \<String\>\]: 
  \[ExecuteImmediately \<Boolean?\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[IsValidationOnly \<Boolean?\>\]: 
  \[Justification \<String\>\]: 
  \[RequestState \<String\>\]: 
  \[RequestStatus \<String\>\]: 
  \[RequestType \<String\>\]: 
  \[Requestor \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AltSecId \<String\>\]: 
    \[ConnectedOrganization \<IMicrosoftGraphConnectedOrganization\>\]: connectedOrganization
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[ExternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
        \[Id \<String\>\]: Read-only.
        \[DeletedDateTime \<DateTime?\>\]: 
      \[IdentitySources \<IMicrosoftGraphIdentitySource\[\]\>\]: 
      \[InternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
      \[State \<String\>\]: connectedOrganizationState
    \[ConnectedOrganizationId \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[Email \<String\>\]: 
    \[ObjectId \<String\>\]: 
    \[OnPremisesSecurityIdentifier \<String\>\]: 
    \[PrincipalName \<String\>\]: 
    \[Type \<String\>\]: 

REQUESTOR \<IMicrosoftGraphAccessPackageSubject\>: accessPackageSubject
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AltSecId \<String\>\]: 
  \[ConnectedOrganization \<IMicrosoftGraphConnectedOrganization\>\]: connectedOrganization
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[CreatedBy \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[ExternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[DeletedDateTime \<DateTime?\>\]: 
    \[IdentitySources \<IMicrosoftGraphIdentitySource\[\]\>\]: 
    \[InternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
    \[ModifiedBy \<String\>\]: 
    \[ModifiedDateTime \<DateTime?\>\]: 
    \[State \<String\>\]: connectedOrganizationState
  \[ConnectedOrganizationId \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[Email \<String\>\]: 
  \[ObjectId \<String\>\]: 
  \[OnPremisesSecurityIdentifier \<String\>\]: 
  \[PrincipalName \<String\>\]: 
  \[Type \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresourcerequest](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresourcerequest)

