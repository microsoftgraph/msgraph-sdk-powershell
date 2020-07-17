---
external help file:
Module Name: Microsoft.Graph.Groups.ProfilePhoto
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.profilephoto/update-mggroupphoto
schema: 2.0.0
---

# Update-MgGroupPhoto

## SYNOPSIS
Update the navigation property photos in groups

## SYNTAX

### UpdateExpanded3 (Default)
```
Update-MgGroupPhoto -GroupId <String> [-Height <Int32>] [-Id <String>] [-Width <Int32>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgGroupPhoto -GroupId <String> -ProfilePhotoId <String> -BodyParameter <IMicrosoftGraphProfilePhoto>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update3
```
Update-MgGroupPhoto -GroupId <String> -BodyParameter <IMicrosoftGraphProfilePhoto> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgGroupPhoto -GroupId <String> -ProfilePhotoId <String> [-Height <Int32>] [-Id <String>]
 [-Width <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgGroupPhoto -InputObject <IGroupsProfilePhotoIdentity> -BodyParameter <IMicrosoftGraphProfilePhoto>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Update-MgGroupPhoto -InputObject <IGroupsProfilePhotoIdentity> -BodyParameter <IMicrosoftGraphProfilePhoto>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgGroupPhoto -InputObject <IGroupsProfilePhotoIdentity> [-Height <Int32>] [-Id <String>]
 [-Width <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Update-MgGroupPhoto -InputObject <IGroupsProfilePhotoIdentity> [-Height <Int32>] [-Id <String>]
 [-Width <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property photos in groups

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
profilePhoto
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto
Parameter Sets: Update1, Update3, UpdateViaIdentity1, UpdateViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Update1, Update3, UpdateExpanded1, UpdateExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Height
The height of the photo.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateExpanded3, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded3
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
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded3, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded3
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
Type: Microsoft.Graph.PowerShell.Models.IGroupsProfilePhotoIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentity3, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -ProfilePhotoId
key: profilePhoto-id of profilePhoto

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Width
The width of the photo.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateExpanded3, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded3
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

### Microsoft.Graph.PowerShell.Models.IGroupsProfilePhotoIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphProfilePhoto>: profilePhoto
  - `[Id <String>]`: Read-only.
  - `[Height <Int32?>]`: The height of the photo. Read-only.
  - `[Width <Int32?>]`: The width of the photo. Read-only.

INPUTOBJECT <IGroupsProfilePhotoIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: group-id of group
  - `[ProfilePhotoId <String>]`: key: profilePhoto-id of profilePhoto

## RELATED LINKS

