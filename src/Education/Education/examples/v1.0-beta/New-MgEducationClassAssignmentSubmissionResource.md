### Example 1: Using the New-MgEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Resource = @{
		"@odata.type" = "#microsoft.graph.educationExcelResource"
		DisplayName = "userAgeGroup QueryParameter Test.xlsx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RONPUDM2CZKNRF3TGHYUM7Z64WE"
	}
}
New-MgEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Resource = @{
		DisplayName = "_FTP_EDC-61424749-250820211136.pdf"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RL45XVPGDBRW5FLDR62Z5TCMGG3"
		"@odata.type" = "#microsoft.graph.educationFileResource"
	}
}
New-MgEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Resource = @{
		DisplayName = "Wikipedia"
		Link = "https://en.wikipedia.org/wiki/Main_Page"
		"@odata.type" = "#microsoft.graph.educationLinkResource"
	}
}
New-MgEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Resource = @{
		DisplayName = "category.jpg"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RK2WLKUUBAA4ZBKXNBL6QFC2TKG"
		"@odata.type" = "#microsoft.graph.educationMediaResource"
	}
}
New-MgEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Resource = @{
		"@odata.type" = "#microsoft.graph.educationPowerPointResource"
		DisplayName = "state diagram.pptx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXodJYOAkI7rTLhw7ME_e42J/items/01QTY63RN3MHWWM7BNXJD2UD5OMRFEDKN2"
	}
}
New-MgEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the New-MgEducationClassAssignmentSubmissionResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Resource = @{
		"@odata.type" = "microsoft.graph.educationWordResource"
		DisplayName = "Report.docx"
		FileUrl = "https://graph.microsoft.com/beta/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeUEWrOk89nKRpUEr4ZhNYBc/items/016XPCQEELISJB7NVNVBAK7V4UIF6Q27U2"
	}
}
New-MgEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
