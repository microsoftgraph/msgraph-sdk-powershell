---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/new-mgeducationclassassignmentsubmissionresource
schema: 2.0.0
---

# New-MgBetaEducationClassAssignmentSubmissionResource

## SYNOPSIS
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgBetaEducationClassAssignmentSubmissionResource -EducationAssignmentId <String> -EducationClassId <String>
 -EducationSubmissionId <String> [-AdditionalProperties <Hashtable>] [-AssignmentResourceUrl <String>]
 [-Id <String>] [-Resource <IMicrosoftGraphEducationResource>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgBetaEducationClassAssignmentSubmissionResource -EducationAssignmentId <String> -EducationClassId <String>
 -EducationSubmissionId <String> -BodyParameter <IMicrosoftGraphEducationSubmissionResource> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgBetaEducationClassAssignmentSubmissionResource -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationSubmissionResource> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgBetaEducationClassAssignmentSubmissionResource -InputObject <IEducationIdentity>
 [-AdditionalProperties <Hashtable>] [-AssignmentResourceUrl <String>] [-Id <String>]
 [-Resource <IMicrosoftGraphEducationResource>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

## EXAMPLES

### Example 1: Using the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Resource = @{
		"@odata.type" = "#Microsoft.Graph.Beta.educationExcelResource"
		DisplayName = "userAgeGroup QueryParameter Test.xlsx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RONPUDM2CZKNRF3TGHYUM7Z64WE"
	}
}
New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Resource = @{
		DisplayName = "_FTP_EDC-61424749-250820211136.pdf"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RL45XVPGDBRW5FLDR62Z5TCMGG3"
		"@odata.type" = "#Microsoft.Graph.Beta.educationFileResource"
	}
}
New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Resource = @{
		DisplayName = "Wikipedia"
		Link = "https://en.wikipedia.org/wiki/Main_Page"
		"@odata.type" = "#Microsoft.Graph.Beta.educationLinkResource"
	}
}
New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Resource = @{
		DisplayName = "category.jpg"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RK2WLKUUBAA4ZBKXNBL6QFC2TKG"
		"@odata.type" = "#Microsoft.Graph.Beta.educationMediaResource"
	}
}
New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Resource = @{
		"@odata.type" = "#Microsoft.Graph.Beta.educationPowerPointResource"
		DisplayName = "state diagram.pptx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RN3MHWWM7BNXJD2UD5OMRFEDKN2"
	}
}
New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Resource = @{
		"@odata.type" = "Microsoft.Graph.Beta.educationWordResource"
		DisplayName = "Report.docx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeUEWrOk89nKRpUEr4ZhNYBc/items/016XPCQEELISJB7NVNVBAK7V4UIF6Q27U2"
	}
}
New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignmentResourceUrl
Pointer to the assignment from which this resource was copied.
If this is null, the student uploaded the resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
educationSubmissionResource
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationSubmissionResource
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EducationAssignmentId
key: id of educationAssignment

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
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
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationSubmissionId
key: id of educationSubmission

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Resource
educationResource
To construct, please use Get-Help -Online and see NOTES section for RESOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationResource
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationSubmissionResource

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationSubmissionResource

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationSubmissionResource>: educationSubmissionResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AssignmentResourceUrl <String>]`: Pointer to the assignment from which this resource was copied. If this is null, the student uploaded the resource.
  - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: Display name of resource.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet

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

RESOURCE <IMicrosoftGraphEducationResource>: educationResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: Display name of resource.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet

## RELATED LINKS

