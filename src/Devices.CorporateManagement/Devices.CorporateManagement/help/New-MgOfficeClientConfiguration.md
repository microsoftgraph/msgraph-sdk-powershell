---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgofficeclientconfiguration
schema: 2.0.0
---

# New-MgOfficeClientConfiguration

## SYNOPSIS
Create new navigation property to clientConfigurations for officeConfiguration

## SYNTAX

### CreateExpanded (Default)
```
New-MgOfficeClientConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>] [-UserPreferencePayloadInputFile <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgOfficeClientConfiguration -BodyParameter <IMicrosoftGraphOfficeClientConfiguration> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to clientConfigurations for officeConfiguration

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

### -Assignments
.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOfficeClientConfigurationAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
officeClientConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOfficeClientConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CheckinStatuses
.
To construct, see NOTES section for CHECKINSTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphOfficeClientCheckinStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
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

### -DisplayName
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

### -PolicyPayloadInputFile
Input File for PolicyPayload (.)

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

### -Priority
.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCheckinSummary
officeUserCheckinSummary
To construct, see NOTES section for USERCHECKINSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphOfficeUserCheckinSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPreferencePayloadInputFile
Input File for UserPreferencePayload (.)

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNMENTS \<IMicrosoftGraphOfficeClientConfigurationAssignment\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[Target \<IMicrosoftGraphOfficeConfigurationAssignmentTarget\>\]: officeConfigurationAssignmentTarget
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.

BODYPARAMETER \<IMicrosoftGraphOfficeClientConfiguration\>: officeClientConfiguration
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphOfficeClientConfigurationAssignment\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Target \<IMicrosoftGraphOfficeConfigurationAssignmentTarget\>\]: officeConfigurationAssignmentTarget
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CheckinStatuses \<IMicrosoftGraphOfficeClientCheckinStatus\[\]\>\]: 
    \[AppliedPolicies \<String\[\]\>\]: 
    \[CheckinDateTime \<DateTime?\>\]: 
    \[DeviceName \<String\>\]: 
    \[DevicePlatform \<String\>\]: 
    \[DevicePlatformVersion \<String\>\]: 
    \[ErrorMessage \<String\>\]: 
    \[UserId \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
    \[WasSuccessful \<Boolean?\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[PolicyPayload \<Byte\[\]\>\]: 
  \[Priority \<Int32?\>\]: 
  \[UserCheckinSummary \<IMicrosoftGraphOfficeUserCheckinSummary\>\]: officeUserCheckinSummary
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[FailedUserCount \<Int32?\>\]: 
    \[SucceededUserCount \<Int32?\>\]: 
  \[UserPreferencePayload \<Byte\[\]\>\]: 

CHECKINSTATUSES \<IMicrosoftGraphOfficeClientCheckinStatus\[\]\>: .
  \[AppliedPolicies \<String\[\]\>\]: 
  \[CheckinDateTime \<DateTime?\>\]: 
  \[DeviceName \<String\>\]: 
  \[DevicePlatform \<String\>\]: 
  \[DevicePlatformVersion \<String\>\]: 
  \[ErrorMessage \<String\>\]: 
  \[UserId \<String\>\]: 
  \[UserPrincipalName \<String\>\]: 
  \[WasSuccessful \<Boolean?\>\]: 

USERCHECKINSUMMARY \<IMicrosoftGraphOfficeUserCheckinSummary\>: officeUserCheckinSummary
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[FailedUserCount \<Int32?\>\]: 
  \[SucceededUserCount \<Int32?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgofficeclientconfiguration](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgofficeclientconfiguration)

