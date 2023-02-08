### Example 1: Using the New-MgEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "microsoft.graph.educationExcelResource"
		DisplayName = "Graph Doc pages.xlsx"
		FileUrl = "https://graph.microsoft.com/v1.0/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RIR7PSV4JJSFJHKNPUVUWGPW4O2"
	}
}
New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		DisplayName = "article.pdf"
		"@odata.type" = "#microsoft.graph.educationFileResource"
	}
}
New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		DisplayName = "Where the Wonders of Learning Never Cease | Wonderopolis"
		Link = "https://wonderopolis.org/"
		ThumbnailPreviewUrl = $null
		"@odata.type" = "#microsoft.graph.educationLinkResource"
	}
}
New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "microsoft.graph.educationMediaResource"
		DisplayName = "homework example.PNG"
		FileUrl = "https://graph.microsoft.com/v1.0/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RMUWOKAGSJZ6BHINJVKNMOOJABF"
	}
}
New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "microsoft.graph.educationPowerPointResource"
		DisplayName = "state diagram.pptx"
		FileUrl = "https://graph.microsoft.com/v1.0/drives/b!OPmUsPgnBUiMIXMxWcj3neC1xck6I5NIsnFxfrLdmXoOOmEQNO79QpIMPdOmY3nf/items/01QTY63RN327OXRN6EVFE2Q5FRJZTN5EOJ"
	}
}
New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the New-MgEducationClassAssignmentResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DistributeForStudentWork = $false
	Resource = @{
		"@odata.type" = "microsoft.graph.educationWordResource"
		DisplayName = "Issues and PR in guthub.docx"
		FileUrl = "https://graph.microsoft.com/v1.0/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeUEWrOk89nKRpUEr4ZhNYBc/items/016XPCQEELISJB7NVNVBAK7V4UIF6Q27U2"
	}
}
New-MgEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
