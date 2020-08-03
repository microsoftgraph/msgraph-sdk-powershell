---
external help file:
Module Name: Microsoft.Graph.Users.OutlookUser
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.outlookuser/update-mguseroutlook
schema: 2.0.0
---

# Update-MgUserOutlook

## SYNOPSIS
Update the navigation property outlook in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserOutlook -UserId <String> [-Id <String>] [-MasterCategories <IMicrosoftGraphOutlookCategory[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgUserOutlook -UserId <String> -BodyParameter <IMicrosoftGraphOutlookUser1> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserOutlook -InputObject <IUsersOutlookUserIdentity> -BodyParameter <IMicrosoftGraphOutlookUser1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserOutlook -InputObject <IUsersOutlookUserIdentity> [-Id <String>]
 [-MasterCategories <IMicrosoftGraphOutlookCategory[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property outlook in users

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
outlookUser
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookUser1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IUsersOutlookUserIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MasterCategories
A list of categories defined for the user.
To construct, see NOTES section for MASTERCATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookCategory[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -UserId
key: user-id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookUser1

### Microsoft.Graph.PowerShell.Models.IUsersOutlookUserIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOutlookUser1>: outlookUser
  - `[Id <String>]`: Read-only.
  - `[MasterCategories <IMicrosoftGraphOutlookCategory[]>]`: A list of categories defined for the user.
    - `[Id <String>]`: Read-only.
    - `[Color <String>]`: categoryColor
    - `[DisplayName <String>]`: A unique name that identifies a category in the user's mailbox. After a category is created, the name cannot be changed. Read-only.

INPUTOBJECT <IUsersOutlookUserIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[OutlookCategoryId <String>]`: key: outlookCategory-id of outlookCategory
  - `[OutlookTaskFolderId <String>]`: key: outlookTaskFolder-id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: outlookTaskGroup-id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: outlookTask-id of outlookTask
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: user-id of user

MASTERCATEGORIES <IMicrosoftGraphOutlookCategory[]>: A list of categories defined for the user.
  - `[Id <String>]`: Read-only.
  - `[Color <String>]`: categoryColor
  - `[DisplayName <String>]`: A unique name that identifies a category in the user's mailbox. After a category is created, the name cannot be changed. Read-only.

## RELATED LINKS

