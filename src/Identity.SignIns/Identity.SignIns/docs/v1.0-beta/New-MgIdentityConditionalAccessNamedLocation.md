---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgidentityconditionalaccessnamedlocation
schema: 2.0.0
---

# New-MgIdentityConditionalAccessNamedLocation

## SYNOPSIS
Create a new namedLocation object.
Named locations can be either ipNamedLocation or countryNamedLocation objects.

## SYNTAX

### CreateExpanded (Default)
```
New-MgIdentityConditionalAccessNamedLocation [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-ModifiedDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgIdentityConditionalAccessNamedLocation -BodyParameter <IMicrosoftGraphNamedLocation> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new namedLocation object.
Named locations can be either ipNamedLocation or countryNamedLocation objects.

## EXAMPLES

### Example 1: Create a country named location
```powershell
Connect-MgGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

$params = @{
"@odata.type" = "#microsoft.graph.countryNamedLocation"
DisplayName = "Named location with unknown countries and regions"
CountriesAndRegions = @(
    "US"
    "XK"
)
IncludeUnknownCountriesAndRegions = $true
}

New-MgIdentityConditionalAccessNamedLocation -BodyParameter $params

Id                                   CreatedDateTime      DisplayName                                       ModifiedDateTime
--                                   ---------------      -----------                                       ----------------
1f0fd623-bf8f-4003-9627-32a68c3cdcc1 6/13/2022 8:27:35 AM Named location with unknown countries and regions 6/13/2022 8:27:35 AM
```

This example creates a country named location.

### Example 2: Create an ip named location
```powershell
Connect-MgGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

$params = @{
"@odata.type" = "#microsoft.graph.ipNamedLocation"
DisplayName = "Untrusted IP named location"
IsTrusted = $false
IpRanges = @(
    @{
        "@odata.type" = "#microsoft.graph.iPv4CidrRange"
        CidrAddress = "12.34.221.11/22"
    }
    @{
        "@odata.type" = "#microsoft.graph.iPv6CidrRange"
        CidrAddress = "2001:0:9d38:90d6:0:0:0:0/63"
    }
)
}

New-MgIdentityConditionalAccessNamedLocation -BodyParameter $params

Id                                   CreatedDateTime      DisplayName                 ModifiedDateTime
--                                   ---------------      -----------                 ----------------
0824dbaf-6277-4db0-8112-b29fd356f2c4 6/13/2022 8:41:38 AM Untrusted IP named location 6/13/2022 8:41:38 AM
```

This example creates an Ip named location.

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
namedLocation
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNamedLocation
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents creation date and time of the location using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Human-readable name of the location.

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

### -ModifiedDateTime
The Timestamp type represents last modified date and time of the location using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNamedLocation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNamedLocation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphNamedLocation>: namedLocation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents creation date and time of the location using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[DisplayName <String>]`: Human-readable name of the location.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents last modified date and time of the location using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

## RELATED LINKS

