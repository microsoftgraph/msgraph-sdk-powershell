---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/new-mgeducationmerubric
schema: 2.0.0
---

# New-MgBetaEducationMeRubric

## SYNOPSIS
Create a new educationRubric object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaEducationMeRubric [-AdditionalProperties <Hashtable>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-Description <IMicrosoftGraphEducationItemBody>] [-DisplayName <String>] [-Grading <Hashtable>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-Levels <IMicrosoftGraphRubricLevel[]>]
 [-Qualities <IMicrosoftGraphRubricQuality[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaEducationMeRubric -BodyParameter <IMicrosoftGraphEducationRubric> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a new educationRubric object.

## EXAMPLES

### Example 1: Using the New-MgBetaEducationMeRubric Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DisplayName = "Example Credit Rubric"
	Description = @{
		Content = "This is an example of a credit rubric (no points)"
		ContentType = "text"
	}
	Levels = @(
		@{
			DisplayName = "Good"
			Description = @{
				Content = ""
				ContentType = "text"
			}
		}
		@{
			DisplayName = "Poor"
			Description = @{
				Content = ""
				ContentType = "text"
			}
		}
	)
	Qualities = @(
		@{
			Description = @{
				Content = "Argument"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay's argument is persuasive."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay's argument does not make sense."
						ContentType = "text"
					}
				}
			)
		}
		@{
			Description = @{
				Content = "Spelling and Grammar"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay uses proper spelling and grammar with few or no errors."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay has numerous errors in spelling and/or grammar."
						ContentType = "text"
					}
				}
			)
		}
	)
}
New-MgBetaEducationMeRubric -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgBetaEducationMeRubric Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DisplayName = "Example Points Rubric"
	Description = @{
		Content = "This is an example of a rubric with points"
		ContentType = "text"
	}
	Levels = @(
		@{
			DisplayName = "Good"
			Description = @{
				Content = ""
				ContentType = "text"
			}
			Grading = @{
				"@odata.type" = "#Microsoft.Graph.Beta.educationAssignmentPointsGradeType"
				MaxPoints = 
			}
		}
		@{
			DisplayName = "Poor"
			Description = @{
				Content = ""
				ContentType = "text"
			}
			Grading = @{
				"@odata.type" = "#Microsoft.Graph.Beta.educationAssignmentPointsGradeType"
				MaxPoints = 
			}
		}
	)
	Qualities = @(
		@{
			Description = @{
				Content = "Argument"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay's argument is persuasive."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay's argument does not make sense."
						ContentType = "text"
					}
				}
			)
			Weight = 50.0
		}
		@{
			Description = @{
				Content = "Spelling and Grammar"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay uses proper spelling and grammar with few or no errors."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay has numerous errors in spelling and/or grammar."
						ContentType = "text"
					}
				}
			)
			Weight = 50.0
		}
	)
	Grading = @{
		"@odata.type" = "#Microsoft.Graph.Beta.educationAssignmentPointsGradeType"
	}
}
New-MgBetaEducationMeRubric -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
educationRubric
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationRubric
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
educationItemBody
To construct, please use Get-Help -Online and see NOTES section for DESCRIPTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationItemBody
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of this rubric.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Grading
educationAssignmentGradeType

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Levels
The collection of levels making up this rubric.
To construct, please use Get-Help -Online and see NOTES section for LEVELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRubricLevel[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Qualities
The collection of qualities making up this rubric.
To construct, please use Get-Help -Online and see NOTES section for QUALITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRubricQuality[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationRubric

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationRubric

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationRubric>: educationRubric
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: 
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: The name of this rubric.
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Levels <IMicrosoftGraphRubricLevel[]>]`: The collection of levels making up this rubric.
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: The name of this rubric level.
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LevelId <String>]`: The ID of this resource.
  - `[Qualities <IMicrosoftGraphRubricQuality[]>]`: The collection of qualities making up this rubric.
    - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: The collection of criteria for this rubric quality.
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: The name of this rubric quality.
    - `[QualityId <String>]`: The ID of this resource.
    - `[Weight <Single?>]`: If present, a numerical weight for this quality.  Weights must add up to 100.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

DESCRIPTION <IMicrosoftGraphEducationItemBody>: educationItemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: 
  - `[ContentType <String>]`: bodyType

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

LEVELS <IMicrosoftGraphRubricLevel[]>: The collection of levels making up this rubric.
  - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: 
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: The name of this rubric level.
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LevelId <String>]`: The ID of this resource.

QUALITIES <IMicrosoftGraphRubricQuality[]>: The collection of qualities making up this rubric.
  - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: The collection of criteria for this rubric quality.
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: 
      - `[ContentType <String>]`: bodyType
  - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
  - `[DisplayName <String>]`: The name of this rubric quality.
  - `[QualityId <String>]`: The ID of this resource.
  - `[Weight <Single?>]`: If present, a numerical weight for this quality.  Weights must add up to 100.

## RELATED LINKS

