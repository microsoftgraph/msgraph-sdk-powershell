---
external help file:
Module Name: Microsoft.Graph.Identity.TrustFramework
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.trustframework/invoke-mguploadtrustframeworkkeysetpkcs12
schema: 2.0.0
---

# Invoke-MgUploadTrustFrameworkKeySetPkcs12

## SYNOPSIS
Invoke action uploadPkcs12

## SYNTAX

### UploadExpanded (Default)
```
Invoke-MgUploadTrustFrameworkKeySetPkcs12 -TrustFrameworkKeySetId <String> [-Key <String>]
 [-Password <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Upload
```
Invoke-MgUploadTrustFrameworkKeySetPkcs12 -TrustFrameworkKeySetId <String>
 -BodyParameter <IPaths11Ap814TrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphUploadpkcs12PostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UploadViaIdentity
```
Invoke-MgUploadTrustFrameworkKeySetPkcs12 -InputObject <IIdentityTrustFrameworkIdentity>
 -BodyParameter <IPaths11Ap814TrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphUploadpkcs12PostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UploadViaIdentityExpanded
```
Invoke-MgUploadTrustFrameworkKeySetPkcs12 -InputObject <IIdentityTrustFrameworkIdentity> [-Key <String>]
 [-Password <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action uploadPkcs12

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
Type: Microsoft.Graph.PowerShell.Models.IPaths11Ap814TrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphUploadpkcs12PostRequestbodyContentApplicationJsonSchema
Parameter Sets: Upload, UploadViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityTrustFrameworkIdentity
Parameter Sets: UploadViaIdentity, UploadViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Key
.

```yaml
Type: System.String
Parameter Sets: UploadExpanded, UploadViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
.

```yaml
Type: System.String
Parameter Sets: UploadExpanded, UploadViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TrustFrameworkKeySetId
key: trustFrameworkKeySet-id of trustFrameworkKeySet

```yaml
Type: System.String
Parameter Sets: Upload, UploadExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IIdentityTrustFrameworkIdentity

### Microsoft.Graph.PowerShell.Models.IPaths11Ap814TrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphUploadpkcs12PostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFrameworkKey

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths11Ap814TrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphUploadpkcs12PostRequestbodyContentApplicationJsonSchema>: .
  - `[Key <String>]`: 
  - `[Password <String>]`: 

INPUTOBJECT <IIdentityTrustFrameworkIdentity>: Identity Parameter
  - `[TrustFrameworkKeySetId <String>]`: key: trustFrameworkKeySet-id of trustFrameworkKeySet
  - `[TrustFrameworkPolicyId <String>]`: key: trustFrameworkPolicy-id of trustFrameworkPolicy

## RELATED LINKS

