---
external help file:
Module Name: Microsoft.Graph.Sites.OneNote
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites.onenote/update-mgsiteonenoteoperation
schema: 2.0.0
---

# Update-MgSiteOnenoteOperation

## SYNOPSIS
Update the navigation property operations in sites

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSiteOnenoteOperation -OnenoteOperationId <String> -SiteId <String> [-Code <String>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastActionDateTime <DateTime>] [-Message <String>]
 [-PercentComplete <String>] [-ResourceId <String>] [-ResourceLocation <String>] [-Status <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSiteOnenoteOperation -OnenoteOperationId <String> -SiteId <String>
 -BodyParameter <IMicrosoftGraphOnenoteOperation> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSiteOnenoteOperation -InputObject <ISitesOneNoteIdentity>
 -BodyParameter <IMicrosoftGraphOnenoteOperation> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSiteOnenoteOperation -InputObject <ISitesOneNoteIdentity> [-Code <String>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastActionDateTime <DateTime>] [-Message <String>]
 [-PercentComplete <String>] [-ResourceId <String>] [-ResourceLocation <String>] [-Status <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property operations in sites

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
onenoteOperation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteOperation
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Code
The error code.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
The start time of the operation.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISitesOneNoteIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LastActionDateTime
The time of the last action of the operation.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Message
The error message.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OnenoteOperationId
key: onenoteOperation-id of onenoteOperation

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -PercentComplete
The operation percent complete if the operation is still in running status

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceId
The resource id.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceLocation
The resource URI for the object.
For example, the resource URI for a copied page or section.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SiteId
key: site-id of site

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Status
operationStatus

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteOperation

### Microsoft.Graph.PowerShell.Models.ISitesOneNoteIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphOnenoteOperation>: onenoteOperation
  - `[CreatedDateTime <DateTime?>]`: The start time of the operation.
  - `[LastActionDateTime <DateTime?>]`: The time of the last action of the operation.
  - `[Status <String>]`: operationStatus
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: The error code.
  - `[Message <String>]`: The error message.
  - `[PercentComplete <String>]`: The operation percent complete if the operation is still in running status
  - `[ResourceId <String>]`: The resource id.
  - `[ResourceLocation <String>]`: The resource URI for the object. For example, the resource URI for a copied page or section.

#### INPUTOBJECT <ISitesOneNoteIdentity>: Identity Parameter
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenoteOperationId <String>]`: key: onenoteOperation-id of onenoteOperation
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteResourceId <String>]`: key: onenoteResource-id of onenoteResource
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OnenoteSectionId1 <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[SectionGroupId1 <String>]`: key: sectionGroup-id of sectionGroup
  - `[SiteId <String>]`: key: site-id of site

## RELATED LINKS

