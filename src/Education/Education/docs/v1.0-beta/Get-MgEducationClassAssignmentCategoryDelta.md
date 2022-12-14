---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/get-mgeducationclassassignmentcategorydelta
schema: 2.0.0
---

# Get-MgBetaEducationClassAssignmentCategoryDelta

## SYNOPSIS
Invoke function delta

## SYNTAX

### Delta (Default)
```
Get-MgBetaEducationClassAssignmentCategoryDelta -EducationClassId <String> [-Count] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>]
 [<CommonParameters>]
```

### Delta1
```
Get-MgBetaEducationClassAssignmentCategoryDelta -EducationAssignmentId <String> -EducationClassId <String>
 [-Count] [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [<CommonParameters>]
```

### DeltaViaIdentity
```
Get-MgBetaEducationClassAssignmentCategoryDelta -InputObject <IEducationIdentity> [-Count] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>]
 [<CommonParameters>]
```

### DeltaViaIdentity1
```
Get-MgBetaEducationClassAssignmentCategoryDelta -InputObject <IEducationIdentity> [-Count] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke function delta

## EXAMPLES

### Example 1: Using the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationClassAssignmentCategoryDelta -EducationClassId $educationClassId -Top 3 
```

This example shows how to use the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationClassAssignmentCategoryDelta -EducationClassId $educationClassId -Deltatoken "7ORzTfzlUEGDy6BRE3OC-3ePBbvLHCRe4aJ_hjaBKJxUHmn_ODgoM4xreLS7YRaxc-iACeqCQsT5Tb0u9vn6QXYflO6j0sRgRQlhcfR7DApZYl6uZqiXcR7H0G14btPqR761sKWNc0jgiczrHGF6dGfSQwsLzPT46og-84ArhOU.Jnxvkr08FE-QBvEYstYel3JZUrgwgTauo-GmpbdWeSA" 
```

This example shows how to use the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationClassAssignmentCategoryDelta -EducationClassId $educationClassId -Deltatoken "7ORzTfzlUEGDy6BRE3OC-3ePBbvLHCRe4aJ_hjaBKJxUHmn_ODgoM4xreLS7YRaxc-iACeqCQsT5Tb0u9vn6QXYflO6j0sRgRQlhcfR7DApZYl6uZqiXcR7H0G14btPqR761sKWNc0jgiczrHGF6dGfSQwsLzPT46og-84ArhOU.Jnxvkr08FE-QBvEYstYel3JZUrgwgTauo-GmpbdWeSA"  -OutFile $outFileId
```

This example shows how to use the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationClassAssignmentCategoryDelta -EducationClassId $educationClassId -Skiptoken "U43TyYWKlRvJ6wWxZOfJvkp22nMqShRw9f-GxBtG2FDy9b1hMDaAJGdLb7n2fh1IVSFtBcXz0jxjIEihcR91dS3R7i8Z2IMtxIn9rKbK9Jvurj6jCH-lDbSNatdesrK0PJ5zpZ_-i8HyqkdtLhWD9tewXVArIqQWJA7gJz8z4paG2q0MU9rixrQOTe7WIXikPiBTUPilHuUW-o1k7cvqke3K7llJbU3G7z_O7WGoVGE.l8-2OcBi9ZWAhwhPnXvJ-kyyk8GNb6-H4o6qofP5YBY" 
```

This example shows how to use the Get-MgBetaEducationClassAssignmentCategoryDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -Count
Include count of items

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

### -EducationAssignmentId
key: id of educationAssignment

```yaml
Type: System.String
Parameter Sets: Delta1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationClassId
key: id of educationClass

```yaml
Type: System.String
Parameter Sets: Delta, Delta1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: (All)
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity
Parameter Sets: DeltaViaIdentity, DeltaViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationCategory

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: key: id of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: key: id of educationAssignmentResource
  - `[EducationCategoryId <String>]`: key: id of educationCategory
  - `[EducationClassId <String>]`: key: id of educationClass
  - `[EducationOutcomeId <String>]`: key: id of educationOutcome
  - `[EducationRubricId <String>]`: key: id of educationRubric
  - `[EducationSchoolId <String>]`: key: id of educationSchool
  - `[EducationSubmissionId <String>]`: key: id of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: key: id of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: key: id of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: key: id of educationSynchronizationProfile
  - `[EducationUserId <String>]`: key: id of educationUser

## RELATED LINKS

