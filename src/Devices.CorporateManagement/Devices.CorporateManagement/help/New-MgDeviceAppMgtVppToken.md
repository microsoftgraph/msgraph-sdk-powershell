---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtvpptoken
schema: 2.0.0
---

# New-MgDeviceAppMgtVppToken

## SYNOPSIS
Create new navigation property to vppTokens for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtVppToken [-AdditionalProperties <Hashtable>] [-AppleId <String>] [-AutomaticallyUpdateApps]
 [-ClaimTokenManagementFromExternalMdm] [-CountryOrRegion <String>] [-DataSharingConsentGranted]
 [-DisplayName <String>] [-ExpirationDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-LastSyncDateTime <DateTime>] [-LastSyncStatus <String>] [-LocationName <String>]
 [-OrganizationName <String>] [-RoleScopeTagIds <String[]>] [-State <String>] [-Token <String>]
 [-TokenActionResults <IMicrosoftGraphVppTokenActionResult[]>] [-VppTokenAccountType <String>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtVppToken -BodyParameter <IMicrosoftGraphVppToken> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to vppTokens for deviceAppManagement

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

### -AppleId
The apple Id associated with the given Apple Volume Purchase Program Token.

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

### -AutomaticallyUpdateApps
Whether or not apps for the VPP token will be automatically updated.

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

### -BodyParameter
You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education.
This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune.
You can then synchronize your volume purchase information with Intune and track your volume-purchased app use.
You can upload multiple Apple VPP Business or Education tokens.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphVppToken
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClaimTokenManagementFromExternalMdm
Admin consent to allow claiming token management from external MDM.

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

### -CountryOrRegion
Whether or not apps for the VPP token will be automatically updated.

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

### -DataSharingConsentGranted
Consent granted for data sharing with the Apple Volume Purchase Program.

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

### -DisplayName
An admin specified token friendly name.

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

### -ExpirationDateTime
The expiration date time of the Apple Volume Purchase Program Token.

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

### -LastModifiedDateTime
Last modification date time associated with the Apple Volume Purchase Program Token.

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

### -LastSyncDateTime
The last time when an application sync was done with the Apple volume purchase program service using the Apple Volume Purchase Program Token.

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

### -LastSyncStatus
vppTokenSyncStatus

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

### -LocationName
Token location returned from Apple VPP.

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

### -OrganizationName
The organization associated with the Apple Volume Purchase Program Token

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

### -RoleScopeTagIds
Role Scope Tags IDs assigned to this entity.

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
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

### -Token
The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.

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

### -TokenActionResults
The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.
To construct, see NOTES section for TOKENACTIONRESULTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphVppTokenActionResult[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VppTokenAccountType
vppTokenAccountType

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVppToken
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVppToken
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphVppToken1\>: You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education.
This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune.
You can then synchronize your volume purchase information with Intune and track your volume-purchased app use.
You can upload multiple Apple VPP Business or Education tokens.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AppleId \<String\>\]: The apple Id associated with the given Apple Volume Purchase Program Token.
  \[AutomaticallyUpdateApps \<Boolean?\>\]: Whether or not apps for the VPP token will be automatically updated.
  \[CountryOrRegion \<String\>\]: Whether or not apps for the VPP token will be automatically updated.
  \[ExpirationDateTime \<DateTime?\>\]: The expiration date time of the Apple Volume Purchase Program Token.
  \[LastModifiedDateTime \<DateTime?\>\]: Last modification date time associated with the Apple Volume Purchase Program Token.
  \[LastSyncDateTime \<DateTime?\>\]: The last time when an application sync was done with the Apple volume purchase program service using the Apple Volume Purchase Program Token.
  \[LastSyncStatus \<String\>\]: vppTokenSyncStatus
  \[OrganizationName \<String\>\]: The organization associated with the Apple Volume Purchase Program Token
  \[State \<String\>\]: 
  \[Token \<String\>\]: The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.
  \[VppTokenAccountType \<String\>\]: vppTokenAccountType

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtvpptoken](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtvpptoken)

