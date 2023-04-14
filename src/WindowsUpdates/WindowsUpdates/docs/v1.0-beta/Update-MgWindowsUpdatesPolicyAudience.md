---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/update-mgwindowsupdatespolicyaudience
schema: 2.0.0
---

# Update-MgWindowsUpdatesPolicyAudience

## SYNOPSIS
Update the navigation property audience in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgWindowsUpdatesPolicyAudience -UpdatePolicyId <String> [-AdditionalProperties <Hashtable>]
 [-ApplicableContent <IMicrosoftGraphWindowsUpdatesApplicableContent[]>]
 [-Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-Id <String>]
 [-Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgWindowsUpdatesPolicyAudience -UpdatePolicyId <String>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesDeploymentAudience> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgWindowsUpdatesPolicyAudience -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesDeploymentAudience> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgWindowsUpdatesPolicyAudience -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-ApplicableContent <IMicrosoftGraphWindowsUpdatesApplicableContent[]>]
 [-Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-Id <String>]
 [-Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property audience in admin

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicableContent
Content eligible to deploy to devices in the audience.
Not nullable.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for APPLICABLECONTENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesApplicableContent[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
deploymentAudience
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentAudience
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Exclusions
Specifies the assets to exclude from the audience.
To construct, please use Get-Help -Online and see NOTES section for EXCLUSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Members
Specifies the assets to include in the audience.
To construct, please use Get-Help -Online and see NOTES section for MEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdatePolicyId
The unique identifier of updatePolicy

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentAudience

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgWuPolicyAudience

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLICABLECONTENT <IMicrosoftGraphWindowsUpdatesApplicableContent[]>: Content eligible to deploy to devices in the audience. Not nullable. Read-only.
  - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DisplayName <String>]`: The display name of the content. Read-only.
    - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]`: Collection of devices and recommendations for applicable catalog content.
    - `[DeviceId <String>]`: 
    - `[RecommendedBy <String[]>]`: Collection of vendors who recommend the content.

BODYPARAMETER <IMicrosoftGraphWindowsUpdatesDeploymentAudience>: deploymentAudience
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplicableContent <IMicrosoftGraphWindowsUpdatesApplicableContent[]>]`: Content eligible to deploy to devices in the audience. Not nullable. Read-only.
    - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[DisplayName <String>]`: The display name of the content. Read-only.
      - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]`: Collection of devices and recommendations for applicable catalog content.
      - `[DeviceId <String>]`: 
      - `[RecommendedBy <String[]>]`: Collection of vendors who recommend the content.
  - `[Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to exclude from the audience.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to include in the audience.

EXCLUSIONS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: Specifies the assets to exclude from the audience.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

MEMBERS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: Specifies the assets to include in the audience.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

## RELATED LINKS

