---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryfederationconfiguration
schema: 2.0.0
---

# New-MgDirectoryFederationConfiguration

## SYNOPSIS
Create new navigation property to federationConfigurations for directory

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDirectoryFederationConfiguration [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDirectoryFederationConfiguration -BodyParameter <IMicrosoftGraphIdentityProviderBase> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to federationConfigurations for directory

## EXAMPLES

### Example 1: Using the New-MgDirectoryFederationConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	"@odata.type" = "microsoft.graph.samlOrWsFedExternalDomainFederation"
	IssuerUri = "https://contoso.com/issuerUri"
	DisplayName = "contoso display name"
	MetadataExchangeUri = "https://contoso.com/metadataExchangeUri"
	PassiveSignInUri = "https://contoso.com/signin"
	PreferredAuthenticationProtocol = "wsFed"
	Domains = @(
		@{
			"@odata.type" = "microsoft.graph.externalDomainName"
			Id = "contoso.com"
		}
	)
	SigningCertificate = "MIIDADCCAeigAwIBAgIQEX41y8r6"
}
New-MgDirectoryFederationConfiguration -BodyParameter $params
```

This example shows how to use the New-MgDirectoryFederationConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
identityProviderBase
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityProviderBase
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name of the identity provider.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityProviderBase

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityProviderBase

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphIdentityProviderBase>: identityProviderBase
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the identity provider.

## RELATED LINKS

