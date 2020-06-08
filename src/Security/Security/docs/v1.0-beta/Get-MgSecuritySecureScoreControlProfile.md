---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/get-mgsecuritysecurescorecontrolprofile
schema: 2.0.0
---

# Get-MgSecuritySecureScoreControlProfile

## SYNOPSIS
Get secureScoreControlProfiles from Security

## SYNTAX

### List (Default)
```
Get-MgSecuritySecureScoreControlProfile [-Count] [-ExpandProperty <String[]>] [-Filter <String>]
 [-PageSize <Int32>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [<CommonParameters>]
```

### Get
```
Get-MgSecuritySecureScoreControlProfile -SecureScoreControlProfileId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgSecuritySecureScoreControlProfile -InputObject <ISecurityIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get secureScoreControlProfiles from Security

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
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISecurityIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Top

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -SecureScoreControlProfileId
key: secureScoreControlProfile-id of secureScoreControlProfile

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScoreControlProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: key: alert-id of alert
  - `[CloudAppSecurityProfileId <String>]`: key: cloudAppSecurityProfile-id of cloudAppSecurityProfile
  - `[DomainSecurityProfileId <String>]`: key: domainSecurityProfile-id of domainSecurityProfile
  - `[FileSecurityProfileId <String>]`: key: fileSecurityProfile-id of fileSecurityProfile
  - `[HostSecurityProfileId <String>]`: key: hostSecurityProfile-id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: ipSecurityProfile-id of ipSecurityProfile
  - `[ProviderTenantSettingId <String>]`: key: providerTenantSetting-id of providerTenantSetting
  - `[SecureScoreControlProfileId <String>]`: key: secureScoreControlProfile-id of secureScoreControlProfile
  - `[SecureScoreId <String>]`: key: secureScore-id of secureScore
  - `[SecurityActionId <String>]`: key: securityAction-id of securityAction
  - `[TiIndicatorId <String>]`: key: tiIndicator-id of tiIndicator
  - `[UserSecurityProfileId <String>]`: key: userSecurityProfile-id of userSecurityProfile

## RELATED LINKS

