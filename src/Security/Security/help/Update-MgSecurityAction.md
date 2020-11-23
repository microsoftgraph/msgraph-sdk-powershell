---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityaction
schema: 2.0.0
---

# Update-MgSecurityAction

## SYNOPSIS
Update the navigation property securityActions in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityAction -SecurityActionId <String> [-ActionReason <String>] [-AdditionalProperties <Hashtable>]
 [-AppId <String>] [-AzureTenantId <String>] [-ClientContext <String>] [-CompletedDateTime <DateTime>]
 [-CreatedDateTime <DateTime>] [-ErrorInfo <IMicrosoftGraphResultInfo>] [-Id <String>]
 [-LastActionDateTime <DateTime>] [-Name <String>] [-Parameters <IMicrosoftGraphKeyValuePair[]>]
 [-States <IMicrosoftGraphSecurityActionState[]>] [-Status <String>] [-User <String>]
 [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgSecurityAction -SecurityActionId <String> -BodyParameter <IMicrosoftGraphSecurityAction> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityAction -InputObject <ISecurityIdentity> [-ActionReason <String>]
 [-AdditionalProperties <Hashtable>] [-AppId <String>] [-AzureTenantId <String>] [-ClientContext <String>]
 [-CompletedDateTime <DateTime>] [-CreatedDateTime <DateTime>] [-ErrorInfo <IMicrosoftGraphResultInfo>]
 [-Id <String>] [-LastActionDateTime <DateTime>] [-Name <String>] [-Parameters <IMicrosoftGraphKeyValuePair[]>]
 [-States <IMicrosoftGraphSecurityActionState[]>] [-Status <String>] [-User <String>]
 [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityAction -InputObject <ISecurityIdentity> -BodyParameter <IMicrosoftGraphSecurityAction>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property securityActions in security

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

### -ActionReason
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureTenantId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
securityAction
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphSecurityAction
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientContext
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompletedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ErrorInfo
ResultInfo
To construct, see NOTES section for ERRORINFO properties and create a hash table.

```yaml
Type: IMicrosoftGraphResultInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: ISecurityIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastActionDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameters
.
To construct, see NOTES section for PARAMETERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphKeyValuePair[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityActionId
key: id of securityAction

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -States
.
To construct, see NOTES section for STATES properties and create a hash table.

```yaml
Type: IMicrosoftGraphSecurityActionState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
operationStatus

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -User
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformation
securityVendorInformation
To construct, see NOTES section for VENDORINFORMATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphSecurityVendorInformation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAction
### Microsoft.Graph.PowerShell.Models.ISecurityIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphSecurityAction\>: securityAction
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ActionReason \<String\>\]: 
  \[AppId \<String\>\]: 
  \[AzureTenantId \<String\>\]: 
  \[ClientContext \<String\>\]: 
  \[CompletedDateTime \<DateTime?\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[ErrorInfo \<IMicrosoftGraphResultInfo\>\]: ResultInfo
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Code \<Int32?\>\]: 
    \[Message \<String\>\]: 
    \[Subcode \<Int32?\>\]: 
  \[LastActionDateTime \<DateTime?\>\]: 
  \[Name \<String\>\]: 
  \[Parameters \<IMicrosoftGraphKeyValuePair\[\]\>\]: 
    \[Name \<String\>\]: Name for this key-value pair
    \[Value \<String\>\]: Value for this key-value pair
  \[States \<IMicrosoftGraphSecurityActionState\[\]\>\]: 
    \[AppId \<String\>\]: 
    \[Status \<String\>\]: operationStatus
    \[UpdatedDateTime \<DateTime?\>\]: 
    \[User \<String\>\]: 
  \[Status \<String\>\]: operationStatus
  \[User \<String\>\]: 
  \[VendorInformation \<IMicrosoftGraphSecurityVendorInformation\>\]: securityVendorInformation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
    \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

ERRORINFO \<IMicrosoftGraphResultInfo\>: ResultInfo
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Code \<Int32?\>\]: 
  \[Message \<String\>\]: 
  \[Subcode \<Int32?\>\]: 

INPUTOBJECT \<ISecurityIdentity\>: Identity Parameter
  \[AlertId \<String\>\]: key: id of alert
  \[CloudAppSecurityProfileId \<String\>\]: key: id of cloudAppSecurityProfile
  \[DomainSecurityProfileId \<String\>\]: key: id of domainSecurityProfile
  \[FileSecurityProfileId \<String\>\]: key: id of fileSecurityProfile
  \[HostSecurityProfileId \<String\>\]: key: id of hostSecurityProfile
  \[IPSecurityProfileId \<String\>\]: key: id of ipSecurityProfile
  \[ProviderTenantSettingId \<String\>\]: key: id of providerTenantSetting
  \[SecureScoreControlProfileId \<String\>\]: key: id of secureScoreControlProfile
  \[SecureScoreId \<String\>\]: key: id of secureScore
  \[SecurityActionId \<String\>\]: key: id of securityAction
  \[TiIndicatorId \<String\>\]: key: id of tiIndicator
  \[UserSecurityProfileId \<String\>\]: key: id of userSecurityProfile

PARAMETERS \<IMicrosoftGraphKeyValuePair\[\]\>: .
  \[Name \<String\>\]: Name for this key-value pair
  \[Value \<String\>\]: Value for this key-value pair

STATES \<IMicrosoftGraphSecurityActionState\[\]\>: .
  \[AppId \<String\>\]: 
  \[Status \<String\>\]: operationStatus
  \[UpdatedDateTime \<DateTime?\>\]: 
  \[User \<String\>\]: 

VENDORINFORMATION \<IMicrosoftGraphSecurityVendorInformation\>: securityVendorInformation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
  \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityaction](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityaction)

