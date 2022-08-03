---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtvpptoken
schema: 2.0.0
---

# New-MgDeviceAppMgtVppToken

## SYNOPSIS
Create new navigation property to vppTokens for deviceAppManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceAppMgtVppToken [-AdditionalProperties <Hashtable>] [-AppleId <String>] [-AutomaticallyUpdateApps]
 [-CountryOrRegion <String>] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-LastSyncDateTime <DateTime>] [-LastSyncStatus <VppTokenSyncStatus>]
 [-OrganizationName <String>] [-State <VppTokenState>] [-Token <String>]
 [-VppTokenAccountType <VppTokenAccountType>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceAppMgtVppToken -BodyParameter <IMicrosoftGraphVppToken1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to vppTokens for deviceAppManagement

## EXAMPLES

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

### -AppleId
The apple Id associated with the given Apple Volume Purchase Program Token.

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

### -AutomaticallyUpdateApps
Whether or not apps for the VPP token will be automatically updated.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education.
This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune.
You can then synchronize your volume purchase information with Intune and track your volume-purchased app use.
You can upload multiple Apple VPP Business or Education tokens.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVppToken1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CountryOrRegion
Whether or not apps for the VPP token will be automatically updated.

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

### -ExpirationDateTime
The expiration date time of the Apple Volume Purchase Program Token.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### -LastModifiedDateTime
Last modification date time associated with the Apple Volume Purchase Program Token.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSyncDateTime
The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSyncStatus
Possible sync statuses associated with an Apple Volume Purchase Program token.

```yaml
Type: Microsoft.Graph.PowerShell.Support.VppTokenSyncStatus
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationName
The organization associated with the Apple Volume Purchase Program Token

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

### -State
Possible states associated with an Apple Volume Purchase Program token.

```yaml
Type: Microsoft.Graph.PowerShell.Support.VppTokenState
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Token
The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.

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

### -VppTokenAccountType
Possible types of an Apple Volume Purchase Program token.

```yaml
Type: Microsoft.Graph.PowerShell.Support.VppTokenAccountType
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVppToken1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVppToken1

## NOTES

ALIASES

### New-MgDeviceAppManagementVppToken

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphVppToken1>: You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education. This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune. You can then synchronize your volume purchase information with Intune and track your volume-purchased app use. You can upload multiple Apple VPP Business or Education tokens.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppleId <String>]`: The apple Id associated with the given Apple Volume Purchase Program Token.
  - `[AutomaticallyUpdateApps <Boolean?>]`: Whether or not apps for the VPP token will be automatically updated.
  - `[CountryOrRegion <String>]`: Whether or not apps for the VPP token will be automatically updated.
  - `[ExpirationDateTime <DateTime?>]`: The expiration date time of the Apple Volume Purchase Program Token.
  - `[LastModifiedDateTime <DateTime?>]`: Last modification date time associated with the Apple Volume Purchase Program Token.
  - `[LastSyncDateTime <DateTime?>]`: The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.
  - `[LastSyncStatus <VppTokenSyncStatus?>]`: Possible sync statuses associated with an Apple Volume Purchase Program token.
  - `[OrganizationName <String>]`: The organization associated with the Apple Volume Purchase Program Token
  - `[State <VppTokenState?>]`: Possible states associated with an Apple Volume Purchase Program token.
  - `[Token <String>]`: The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.
  - `[VppTokenAccountType <VppTokenAccountType?>]`: Possible types of an Apple Volume Purchase Program token.

## RELATED LINKS

