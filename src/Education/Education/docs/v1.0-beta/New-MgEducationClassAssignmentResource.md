---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/new-mgeducationclassassignmentresource
schema: 2.0.0
---

# New-MgBetaEducationClassAssignmentResource

## SYNOPSIS
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgBetaEducationClassAssignmentResource -EducationAssignmentId <String> -EducationClassId <String>
 [-AdditionalProperties <Hashtable>] [-DistributeForStudentWork] [-Id <String>]
 [-Resource <IMicrosoftGraphEducationResource>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgBetaEducationClassAssignmentResource -EducationAssignmentId <String> -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationAssignmentResource> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgBetaEducationClassAssignmentResource -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationAssignmentResource> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgBetaEducationClassAssignmentResource -InputObject <IEducationIdentity> [-AdditionalProperties <Hashtable>]
 [-DistributeForStudentWork] [-Id <String>] [-Resource <IMicrosoftGraphEducationResource>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

## EXAMPLES

### Example 1: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "Microsoft.Graph.Beta.educationExcelResource"
		DisplayName = "Graph Doc pages.xlsx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RIR7PSV4JJSFJHKNPUVUWGPW4O2"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		DisplayName = "article.pdf"
		"@odata.type" = "#Microsoft.Graph.Beta.educationFileResource"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		DisplayName = "Where the Wonders of Learning Never Cease | Wonderopolis"
		Link = "https://wonderopolis.org/"
		ThumbnailPreviewUrl = $null
		"@odata.type" = "#Microsoft.Graph.Beta.educationLinkResource"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "Microsoft.Graph.Beta.educationMediaResource"
		DisplayName = "homework example.PNG"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RMUWOKAGSJZ6BHINJVKNMOOJABF"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "Microsoft.Graph.Beta.educationPowerPointResource"
		DisplayName = "state diagram.pptx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RN327OXRN6EVFE2Q5FRJZTN5EOJ"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		DisplayName = "Template - My Story"
		AppId = "6fbeb90c-3d55-4bd5-82c4-bfe824be4300"
		AppIconWebUrl = "https://statics.teams.cdn.office.net/evergreen-assets/ThirdPartyApps/6fbeb90c-3d55-4bd5-82c4-bfe824be4300_largeImage.png?v=2.0.2"
		TeamsEmbeddedContentUrl = "https://app.api.edu.buncee.com/player/C7B0866C9B7E485EAE21AE14DBC3FD08?embed=1&render_slide_panel=1"
		WebUrl = "https://app.edu.buncee.com/buncee/C7B0866C9B7E485EAE21AE14DBC3FD08"
		"@odata.type" = "#Microsoft.Graph.Beta.educationTeamsAppResource"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 7: Using the New-MgBetaEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "Microsoft.Graph.Beta.educationWordResource"
		DisplayName = "Issues and PR in guthub.docx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeUEWrOk89nKRpUEr4ZhNYBc/items/016XPCQEELISJB7NVNVBAK7V4UIF6Q27U2"
	}
}
New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```

This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
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

### -BodyParameter
educationAssignmentResource
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationAssignmentResource
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DistributeForStudentWork
Indicates whether this resource should be copied to each student submission for modification and submission.
Required

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationAssignmentResource

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationAssignmentResource

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationAssignmentResource>: educationAssignmentResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DistributeForStudentWork <Boolean?>]`: Indicates whether this resource should be copied to each student submission for modification and submission. Required
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

