---
external help file: Microsoft.Graph.Tools.Migration-help.xml
Module Name: Microsoft.Graph.Tools.Migration
online version:
schema: 2.0.0
---

# New-MgMigrationPlan

## SYNOPSIS
{{ Fill in the Synopsis }}

## SYNTAX

### FileOrDirectory (Default)
```
New-MgMigrationPlan [-InputObject] <PSObject> [-GraphProfile <String>] [-UpdatedFilePath <String>]
 [<CommonParameters>]
```

### Directory
```
New-MgMigrationPlan -DirectoryPath <String> [-GraphProfile <String>] [-UpdatedFilePath <String>]
 [<CommonParameters>]
```

### File
```
New-MgMigrationPlan -FilePath <String> [-GraphProfile <String>] [-UpdatedFilePath <String>]
 [<CommonParameters>]
```

## DESCRIPTION
Powershell Microsoft Graph SDK Version I to Version II Migration Toolkit  

## EXAMPLES

### Example 1
```powershell
New-MgMigrationPlan -FilePath $FilePath
```

Changes are only expected if there are Select-MgProfile directives on the script

### Example 2
```powershell
New-MgMigrationPlan -FilePath $FilePath -GraphProfile Beta
```

All commandlets will be updated according to v2 sdk naming convention for beta api version

### Example 3
```powershell
New-MgMigrationPlan -FilePath $FilePath -UpdatedFilePath $UpdatedFilePath
```

Scripts will be modified and dumped to the path provided as a value to UpdatedFilePath

## PARAMETERS

### -DirectoryPath
{{ Fill DirectoryPath Description }}

```yaml
Type: String
Parameter Sets: Directory
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilePath
{{ Fill FilePath Description }}

```yaml
Type: String
Parameter Sets: File
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GraphProfile
{{ Fill GraphProfile Description }}

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
{{ Fill InputObject Description }}

```yaml
Type: PSObject
Parameter Sets: FileOrDirectory
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UpdatedFilePath
{{ Fill UpdatedFilePath Description }}

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Management.Automation.PSObject

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS
