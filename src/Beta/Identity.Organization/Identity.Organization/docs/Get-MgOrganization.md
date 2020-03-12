---
external help file:
Module Name: Microsoft.Graph.Identity.Organization
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.organization/get-mgorganization
schema: 2.0.0
---

# Get-MgOrganization

## SYNOPSIS
Get entity from organization by key

## SYNTAX

### GetExpanded (Default)
```
Get-MgOrganization [-Ids <String[]>] [-Types <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgOrganization -OrganizationId <String> [-Expand <String[]>] [-Select <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgOrganization
 -BodyParameter <IPaths11G1VgqOrganizationMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgOrganization -InputObject <IIdentityOrganizationIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### List
```
Get-MgOrganization [-Count] [-Expand <String[]>] [-Filter <String>] [-Orderby <String[]>] [-Search <String>]
 [-Select <String[]>] [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Get entity from organization by key

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
Type: Microsoft.Graph.PowerShell.Models.IPaths11G1VgqOrganizationMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: Get, GetViaIdentity, List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityOrganizationIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Orderby
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OrganizationId
key: organization-id of organization

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: Get, GetViaIdentity, List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Types
.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.IIdentityOrganizationIdentity

### Microsoft.Graph.PowerShell.Models.IPaths11G1VgqOrganizationMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganization

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths11G1VgqOrganizationMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema>: .
  - `[Ids <String[]>]`: 
  - `[Types <String[]>]`: 

#### INPUTOBJECT <IIdentityOrganizationIdentity>: Identity Parameter
  - `[CertificateBasedAuthConfigurationId <String>]`: key: certificateBasedAuthConfiguration-id of certificateBasedAuthConfiguration
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[OrganizationId <String>]`: key: organization-id of organization
  - `[OrganizationalBrandingId <String>]`: key: organizationalBranding-id of organizationalBranding

## RELATED LINKS

