---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/update-mgexternal
schema: 2.0.0
---

# Update-MgExternal

## SYNOPSIS
Update external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgExternal [-AdditionalProperties <Hashtable>] [-Connections <IMicrosoftGraphExternalConnection[]>]
 [-Id <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgExternal -BodyParameter <IMicrosoftGraphExternal> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update external

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
external
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternal
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Connections
.
To construct, see NOTES section for CONNECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnection[]
Parameter Sets: UpdateExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternal

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExternal>: external
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Connections <IMicrosoftGraphExternalConnection[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Configuration <IMicrosoftGraphConfiguration>]`: configuration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AuthorizedApps <String[]>]`: 
    - `[Description <String>]`: 
    - `[Groups <IMicrosoftGraphExternalGroup[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Members <IMicrosoftGraphExternalGroupMember[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[IdentitySource <String>]`: identitySourceType
        - `[Type <String>]`: externalGroupMemberType
    - `[Items <IMicrosoftGraphExternalItem[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Acl <IMicrosoftGraphAcl[]>]`: 
        - `[AccessType <String>]`: accessType
        - `[IdentitySource <String>]`: 
        - `[Type <String>]`: aclType
        - `[Value <String>]`: 
      - `[Content <IMicrosoftGraphExternalItemContent>]`: externalItemContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Type <String>]`: externalItemContentType
        - `[Value <String>]`: 
      - `[Properties <IMicrosoftGraphProperties>]`: properties
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: 
    - `[Operations <IMicrosoftGraphConnectionOperation[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Error <IMicrosoftGraphErrorDetail>]`: errorDetail
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Details <IMicrosoftGraphInnerErrorDetail[]>]`: 
          - `[Message <String>]`: 
          - `[Source <String>]`: 
        - `[ErrorCode <String>]`: 
        - `[Message <String>]`: 
      - `[Status <String>]`: connectionOperationStatus
    - `[Schema <IMicrosoftGraphSchema>]`: schema
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[BaseType <String>]`: 
      - `[Properties <IMicrosoftGraphProperty[]>]`: 
        - `[Aliases <String[]>]`: 
        - `[IsContent <Boolean?>]`: 
        - `[IsQueryable <Boolean?>]`: 
        - `[IsRefinable <Boolean?>]`: 
        - `[IsRetrievable <Boolean?>]`: 
        - `[IsSearchable <Boolean?>]`: 
        - `[Labels <String[]>]`: 
        - `[Name <String>]`: 
        - `[Type <String>]`: propertyType

CONNECTIONS <IMicrosoftGraphExternalConnection[]>: .
  - `[Id <String>]`: Read-only.
  - `[Configuration <IMicrosoftGraphConfiguration>]`: configuration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthorizedApps <String[]>]`: 
  - `[Description <String>]`: 
  - `[Groups <IMicrosoftGraphExternalGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Members <IMicrosoftGraphExternalGroupMember[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[IdentitySource <String>]`: identitySourceType
      - `[Type <String>]`: externalGroupMemberType
  - `[Items <IMicrosoftGraphExternalItem[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Acl <IMicrosoftGraphAcl[]>]`: 
      - `[AccessType <String>]`: accessType
      - `[IdentitySource <String>]`: 
      - `[Type <String>]`: aclType
      - `[Value <String>]`: 
    - `[Content <IMicrosoftGraphExternalItemContent>]`: externalItemContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: externalItemContentType
      - `[Value <String>]`: 
    - `[Properties <IMicrosoftGraphProperties>]`: properties
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Name <String>]`: 
  - `[Operations <IMicrosoftGraphConnectionOperation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Error <IMicrosoftGraphErrorDetail>]`: errorDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Details <IMicrosoftGraphInnerErrorDetail[]>]`: 
        - `[Message <String>]`: 
        - `[Source <String>]`: 
      - `[ErrorCode <String>]`: 
      - `[Message <String>]`: 
    - `[Status <String>]`: connectionOperationStatus
  - `[Schema <IMicrosoftGraphSchema>]`: schema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseType <String>]`: 
    - `[Properties <IMicrosoftGraphProperty[]>]`: 
      - `[Aliases <String[]>]`: 
      - `[IsContent <Boolean?>]`: 
      - `[IsQueryable <Boolean?>]`: 
      - `[IsRefinable <Boolean?>]`: 
      - `[IsRetrievable <Boolean?>]`: 
      - `[IsSearchable <Boolean?>]`: 
      - `[Labels <String[]>]`: 
      - `[Name <String>]`: 
      - `[Type <String>]`: propertyType

## RELATED LINKS

