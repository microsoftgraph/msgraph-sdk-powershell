---
external help file:
Module Name: Microsoft.Graph.Users.ProfilePhoto
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.profilephoto/new-mguserphoto
schema: 2.0.0
---

# New-MgUserPhoto

## SYNOPSIS
Create new navigation property to photos for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserPhoto -UserId <String> [-Height <Int32>] [-Id <String>] [-Width <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgUserPhoto -UserId <String> -BodyParameter <IMicrosoftGraphProfilePhoto> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserPhoto -InputObject <IUsersProfilePhotoIdentity> -BodyParameter <IMicrosoftGraphProfilePhoto>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserPhoto -InputObject <IUsersProfilePhotoIdentity> [-Height <Int32>] [-Id <String>] [-Width <Int32>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to photos for users

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
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Height
The height of the photo.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IUsersProfilePhotoIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Width
The width of the photo.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto

### Microsoft.Graph.PowerShell.Models.IUsersProfilePhotoIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphProfilePhoto>: profilePhoto
  - `[Id <String>]`: Read-only.
  - `[Height <Int32?>]`: The height of the photo. Read-only.
  - `[Width <Int32?>]`: The width of the photo. Read-only.

#### INPUTOBJECT <IUsersProfilePhotoIdentity>: Identity Parameter
  - `[ProfilePhotoId <String>]`: key: profilePhoto-id of profilePhoto
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

