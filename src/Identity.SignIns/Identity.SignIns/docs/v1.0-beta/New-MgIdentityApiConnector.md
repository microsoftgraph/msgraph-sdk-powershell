---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/new-mgidentityapiconnector
schema: 2.0.0
---

# New-MgBetaIdentityApiConnector

## SYNOPSIS
Create a new identityApiConnector object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityApiConnector [-AdditionalProperties <Hashtable>] [-AuthenticationConfiguration <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-TargetUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityApiConnector -BodyParameter <IMicrosoftGraphIdentityApiConnector> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a new identityApiConnector object.

## EXAMPLES

### Example 1: Using the New-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#Microsoft.Graph.Beta.basicAuthentication"
		Username = "<USERNAME>"
		Password = "<PASSWORD>"
	}
}
New-MgBetaIdentityApiConnector -BodyParameter $params
```

This example shows how to use the New-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someotherapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#Microsoft.Graph.Beta.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "<password>"
	}
}
New-MgBetaIdentityApiConnector -BodyParameter $params
```

This example shows how to use the New-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someotherapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#Microsoft.Graph.Beta.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "<password>"
	}
}
New-MgBetaIdentityApiConnector -BodyParameter $params
```

This example shows how to use the New-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### -AuthenticationConfiguration
apiAuthenticationConfigurationBase

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
identityApiConnector
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityApiConnector
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name of the API connector.

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

### -Id
The unique idenfier for an entity.
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

### -TargetUrl
The URL of the API endpoint to call.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityApiConnector

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityApiConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphIdentityApiConnector>: identityApiConnector
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AuthenticationConfiguration <IMicrosoftGraphApiAuthenticationConfigurationBase>]`: apiAuthenticationConfigurationBase
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The name of the API connector.
  - `[TargetUrl <String>]`: The URL of the API endpoint to call.

## RELATED LINKS

