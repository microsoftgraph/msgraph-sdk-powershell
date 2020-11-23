---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresource
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackageResource

## SYNOPSIS
Create new navigation property to accessPackageResources for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementAccessPackageResource
 [-AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]
 [-AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>] [-AddedBy <String>]
 [-AddedOn <DateTime>] [-AdditionalProperties <Hashtable>]
 [-Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsPendingOnboarding] [-OriginId <String>] [-OriginSystem <String>]
 [-ResourceType <String>] [-Url <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementAccessPackageResource -BodyParameter <IMicrosoftGraphAccessPackageResource>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to accessPackageResources for identityGovernance

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

### -AccessPackageResourceRoles
.
To construct, see NOTES section for ACCESSPACKAGERESOURCEROLES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceRole[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceScopes
.
To construct, see NOTES section for ACCESSPACKAGERESOURCESCOPES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceScope[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddedBy
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

### -AddedOn
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

### -Attributes
.
To construct, see NOTES section for ATTRIBUTES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceAttribute[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageResource
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResource
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
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

### -DisplayName
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

### -IsPendingOnboarding
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

### -OriginId
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

### -OriginSystem
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

### -ResourceType
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

### -Url
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSPACKAGERESOURCEROLES \<IMicrosoftGraphAccessPackageResourceRole\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
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
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[OriginId \<String\>\]: 
  \[OriginSystem \<String\>\]: 

ACCESSPACKAGERESOURCESCOPES \<IMicrosoftGraphAccessPackageResourceScope\[\]\>: .
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
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsRootScope \<Boolean?\>\]: 
  \[OriginId \<String\>\]: 
  \[OriginSystem \<String\>\]: 
  \[RoleOriginId \<String\>\]: 
  \[Url \<String\>\]: 

ATTRIBUTES \<IMicrosoftGraphAccessPackageResourceAttribute\[\]\>: .
  \[AttributeDestination \<IMicrosoftGraphAccessPackageResourceAttributeDestination\>\]: accessPackageResourceAttributeDestination
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AttributeName \<String\>\]: 
  \[AttributeSource \<IMicrosoftGraphAccessPackageResourceAttributeSource\>\]: accessPackageResourceAttributeSource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphAccessPackageResource\>: accessPackageResource
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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresource](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresource)

