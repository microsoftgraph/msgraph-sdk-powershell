---
external help file:
Module Name: Microsoft.Graph.Users.DirectoryObject
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.directoryobject/get-mgusermanager
schema: 2.0.0
---

# Get-MgUserManager

## SYNOPSIS
Get manager from users

## SYNTAX

### Get (Default)
```
Get-MgUserManager -UserId <String> [-Expand <String[]>] [-Select <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserManager -InputObject <IUsersDirectoryObjectIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get manager from users

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

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
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
Type: Microsoft.Graph.PowerShell.Models.IUsersDirectoryObjectIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IUsersDirectoryObjectIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IUsersDirectoryObjectIdentity>: Identity Parameter
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

