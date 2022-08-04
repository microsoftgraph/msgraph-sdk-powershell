---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementderivedcredentials
schema: 2.0.0
---

# New-MgDeviceManagementDerivedCredentials

## SYNOPSIS
Create new navigation property to derivedCredentials for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDerivedCredentials [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-HelpUrl <String>] [-Id <String>] [-Issuer <DeviceManagementDerivedCredentialIssuer>]
 [-NotificationType <DeviceManagementDerivedCredentialNotificationType>] [-RenewalThresholdPercentage <Int32>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDerivedCredentials
 -BodyParameter <IMicrosoftGraphDeviceManagementDerivedCredentialSettings> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to derivedCredentials for deviceManagement

## EXAMPLES

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
Entity that describes tenant level settings for derived credentials
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementDerivedCredentialSettings
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name for the profile.

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

### -HelpUrl
The URL that will be accessible to end users as they retrieve a derived credential using the Company Portal.

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
.

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

### -Issuer
Supported values for the derived credential issuer.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementDerivedCredentialIssuer
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationType
Supported values for the notification type to use.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementDerivedCredentialNotificationType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RenewalThresholdPercentage
The nominal percentage of time before certificate renewal is initiated by the client.

```yaml
Type: System.Int32
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementDerivedCredentialSettings

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementDerivedCredentialSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementDerivedCredentialSettings>: Entity that describes tenant level settings for derived credentials
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The display name for the profile.
  - `[HelpUrl <String>]`: The URL that will be accessible to end users as they retrieve a derived credential using the Company Portal.
  - `[Issuer <DeviceManagementDerivedCredentialIssuer?>]`: Supported values for the derived credential issuer.
  - `[NotificationType <DeviceManagementDerivedCredentialNotificationType?>]`: Supported values for the notification type to use.
  - `[RenewalThresholdPercentage <Int32?>]`: The nominal percentage of time before certificate renewal is initiated by the client.

## RELATED LINKS

