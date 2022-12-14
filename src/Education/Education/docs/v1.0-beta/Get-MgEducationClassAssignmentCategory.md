---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/get-mgeducationclassassignmentcategory
schema: 2.0.0
---

# Get-MgBetaEducationClassAssignmentCategory

## SYNOPSIS
All categories associated with this class.
Nullable.

## SYNTAX

### List3 (Default)
```
Get-MgBetaEducationClassAssignmentCategory -EducationClassId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get1
```
Get-MgBetaEducationClassAssignmentCategory -EducationCategoryId <String> -EducationClassId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### List
```
Get-MgBetaEducationClassAssignmentCategory -EducationAssignmentId <String> -EducationClassId <String>
 [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

## DESCRIPTION
All categories associated with this class.
Nullable.

## EXAMPLES

### Example 1: Using the Get-MgBetaEducationClassAssignmentCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationClassAssignmentCategory -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```

This example shows how to use the Get-MgBetaEducationClassAssignmentCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgBetaEducationClassAssignmentCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationClassAssignmentCategory -EducationClassId $educationClassId -EducationCategoryId $educationCategoryId
```

This example shows how to use the Get-MgBetaEducationClassAssignmentCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List, List3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List, List3
Aliases: CV

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
Parameter Sets: List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationCategoryId
key: id of educationCategory

```yaml
Type: System.String
Parameter Sets: Get1
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
Parameter Sets: Get1, List, List3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List, List3
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
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List, List3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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
Parameter Sets: List, List3
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
Parameter Sets: List, List3
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
Parameter Sets: List, List3
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
Parameter Sets: List, List3
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

