### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		displayName = "Where the Wonders of Learning Never Cease | Wonderopolis"
		link = "https://wonderopolis.org/"
		thumbnailPreviewUrl = $null
		"@odata.type" = "#microsoft.graph.educationLinkResource"
	}
}

New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		"@odata.type" = "microsoft.graph.educationWordResource"
		displayName = "Issues and PR in guthub.docx"
		fileUrl = "https://graph.microsoft.com/v1.0/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeUEWrOk89nKRpUEr4ZhNYBc/items/016XPCQEELISJB7NVNVBAK7V4UIF6Q27U2"
	}
}

New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		displayName = "article.pdf"
		"@odata.type" = "#microsoft.graph.educationFileResource"
	}
}

New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		"@odata.type" = "microsoft.graph.educationPowerPointResource"
		displayName = "state diagram.pptx"
		fileUrl = "https://graph.microsoft.com/v1.0/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RN327OXRN6EVFE2Q5FRJZTN5EOJ"
	}
}

New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		"@odata.type" = "microsoft.graph.educationMediaResource"
		displayName = "homework example.PNG"
		fileUrl = "https://graph.microsoft.com/v1.0/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RMUWOKAGSJZ6BHINJVKNMOOJABF"
	}
}

New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		displayName = "Template - My Story"
		appId = "6fbeb90c-3d55-4bd5-82c4-bfe824be4300"
		appIconWebUrl = "https://statics.teams.cdn.office.net/evergreen-assets/ThirdPartyApps/6fbeb90c-3d55-4bd5-82c4-bfe824be4300_largeImage.png?v=2.0.2"
		teamsEmbeddedContentUrl = "https://app.api.edu.buncee.com/player/C7B0866C9B7E485EAE21AE14DBC3FD08?embed=1&amp;render_slide_panel=1"
		webUrl = "https://app.edu.buncee.com/buncee/C7B0866C9B7E485EAE21AE14DBC3FD08"
		"@odata.type" = "#microsoft.graph.educationTeamsAppResource"
	}
}

New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

