---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetaidentityprovider
schema: 2.0.0
---

# New-MgBetaIdentityProvider

## SYNOPSIS
Create an identity provider object that is of the type specified in the request body.
Among the types of providers derived from identityProviderBase, you can currently create a socialIdentityProvider resource in Microsoft Entra ID.
In Azure AD B2C, this operation can currently create a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityProvider [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityProvider -BodyParameter <IMicrosoftGraphIdentityProviderBase>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an identity provider object that is of the type specified in the request body.
Among the types of providers derived from identityProviderBase, you can currently create a socialIdentityProvider resource in Microsoft Entra ID.
In Azure AD B2C, this operation can currently create a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	"@odata.type" = "microsoft.graph.socialIdentityProvider"
	displayName = "Login with Amazon"
	identityProviderType = "Amazon"
	clientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	clientSecret = "000000000000"
}

New-MgBetaIdentityProvider -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	"@odata.type" = "microsoft.graph.openIdConnectIdentityProvider"
	displayName = "Login with the Contoso identity provider"
	clientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	clientSecret = "12345"
	domainHint = "mycustomoidc"
	metadataUrl = "https://mycustomoidc.com/.well-known/openid-configuration"
	responseMode = "form_post"
	responseType = "code"
	scope = "openid"
}

New-MgBetaIdentityProvider -BodyParameter $params

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	"@odata.type" = "microsoft.graph.appleManagedIdentityProvider"
	displayName = "Sign in with Apple"
	developerId = "UBF8T346G9"
	serviceId = "com.microsoft.rts.b2c.test.client"
	keyId = "99P6D879C4"
	certificateData = "******"
}

New-MgBetaIdentityProvider -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
identityProviderBase
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityProviderBase
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityProviderBase

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityProviderBase

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphIdentityProviderBase>`: identityProviderBase
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the identity provider.

## RELATED LINKS

