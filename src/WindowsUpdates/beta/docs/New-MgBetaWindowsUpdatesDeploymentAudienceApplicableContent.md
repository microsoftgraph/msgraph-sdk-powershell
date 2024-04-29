---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/new-mgbetawindowsupdatesdeploymentaudienceapplicablecontent
schema: 2.0.0
---

# New-MgBetaWindowsUpdatesDeploymentAudienceApplicableContent

## SYNOPSIS
Create new navigation property to applicableContent for admin

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaWindowsUpdatesDeploymentAudienceApplicableContent -DeploymentId <String>
 [-AdditionalProperties <Hashtable>] [-CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]
 [-CatalogEntryId <String>] [-MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaWindowsUpdatesDeploymentAudienceApplicableContent -DeploymentId <String>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesApplicableContent> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaWindowsUpdatesDeploymentAudienceApplicableContent -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesApplicableContent> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaWindowsUpdatesDeploymentAudienceApplicableContent -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]
 [-CatalogEntryId <String>] [-MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to applicableContent for admin

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
applicableContent
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesApplicableContent
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogEntry
catalogEntry
To construct, see NOTES section for CATALOGENTRY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesCatalogEntry
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CatalogEntryId
ID of the catalog entry for the applicable content.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentId
The unique identifier of deployment

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MatchedDevices
Collection of devices and recommendations for applicable catalog content.
To construct, see NOTES section for MATCHEDDEVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesApplicableContent

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesApplicableContent

## NOTES

ALIASES

New-MgBetaWuDeploymentAudienceApplicableContent

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphWindowsUpdatesApplicableContent>`: applicableContent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DisplayName <String>]`: The display name of the content. Read-only.
    - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CatalogEntryId <String>]`: ID of the catalog entry for the applicable content.
  - `[MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]`: Collection of devices and recommendations for applicable catalog content.
    - `[DeviceId <String>]`: Collection of vendors who recommend the content.
    - `[RecommendedBy <String[]>]`: Collection of vendors who recommend the content.

`CATALOGENTRY <IMicrosoftGraphWindowsUpdatesCatalogEntry>`: catalogEntry
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[DisplayName <String>]`: The display name of the content. Read-only.
  - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

`INPUTOBJECT <IWindowsUpdatesIdentity>`: Identity Parameter
  - `[ApplicableContentCatalogEntryId <String>]`: The unique identifier of applicableContent
  - `[ApplicableContentDeviceMatchDeviceId <String>]`: The unique identifier of applicableContentDeviceMatch
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

`MATCHEDDEVICES <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>`: Collection of devices and recommendations for applicable catalog content.
  - `[DeviceId <String>]`: Collection of vendors who recommend the content.
  - `[RecommendedBy <String[]>]`: Collection of vendors who recommend the content.

## RELATED LINKS

