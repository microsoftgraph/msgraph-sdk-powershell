### Example 1: Create an educationWordResource

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		"@odata.type" = "microsoft.graph.educationWordResource"
		displayName = "Report.docx"
		fileUrl = "https://graph.microsoft.com/beta/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeUEWrOk89nKRpUEr4ZhNYBc/items/016XPCQEELISJB7NVNVBAK7V4UIF6Q27U2"
	}
}

New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will create an educationwordresource

### Example 2: Create an educationLinkResource

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		displayName = "Wikipedia"
		link = "https://en.wikipedia.org/wiki/Main_Page"
		"@odata.type" = "#microsoft.graph.educationLinkResource"
	}
}

New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will create an educationlinkresource

### Example 3: Create an educationFileResource

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		displayName = "_FTP_EDC-61424749-250820211136.pdf"
		fileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RL45XVPGDBRW5FLDR62Z5TCMGG3"
		"@odata.type" = "#microsoft.graph.educationFileResource"
	}
}

New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will create an educationfileresource

### Example 4: Create an educationExcelResource

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationExcelResource"
		displayName = "userAgeGroup QueryParameter Test.xlsx"
		fileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RONPUDM2CZKNRF3TGHYUM7Z64WE"
	}
}

New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will create an educationexcelresource

### Example 5: Create an educationPowerPointResource

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationPowerPointResource"
		displayName = "state diagram.pptx"
		fileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RN3MHWWM7BNXJD2UD5OMRFEDKN2"
	}
}

New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will create an educationpowerpointresource

### Example 6: Create an educationMediaResource

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		displayName = "category.jpg"
		fileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RK2WLKUUBAA4ZBKXNBL6QFC2TKG"
		"@odata.type" = "#microsoft.graph.educationMediaResource"
	}
}

New-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will create an educationmediaresource

