### Example 1: Create an educationLinkResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationLinkResource"
		displayName = "Bing site"
		link = "https://www.bing.com"
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationlinkresource

### Example 2: Create an educationWordResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationWordResource"
		displayName = "Word_file.docx"
		file = @{
			odataid = "https://graph.microsoft.com/v1.0/drives/b!-Ik2sRPLDEWy_bR8l75jfeDcpXQcRKVOmcml10NQLQ1F2UVvTgEnTKi0GO59dbCL/items/01VANVJQ3XYXSBRKMQM5GISQGPVO6BNO27"
		}
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationwordresource

### Example 3: Create an educationFileResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationFileResource"
		displayName = "csv_file.csv"
		file = @{
			odataid = "https://graph.microsoft.com/v1.0/drives/b!-Ik2sRPLDEWy_bR8l75jfeDcpXQcRKVOmcml10NQLQ1F2UVvTgEnTKi0GO59dbCL/items/01VANVJQ7A2QVVORGJNVBIC4LLM3XQ6UTS"
		}
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationfileresource

### Example 4: Create an educationExcelResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationExcelResource"
		displayName = "test_excel_file.xlsx"
		file = @{
			odataid = "https://graph.microsoft.com/v1.0/drives/b!-Ik2sRPLDEWy_bR8l75jfeDcpXQcRKVOmcml10NQLQ1F2UVvTgEnTKi0GO59dbCL/items/01VANVJQ5DL55LC4M35VEZWBZFJCX5V4QO"
		}
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationexcelresource

### Example 5: Create an educationPowerPointResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationPowerPointResource"
		displayName = "ppt_file.pptx"
		fileUrl = "https://graph.microsoft.com/v1.0/drives/b!-Ik2sRPLDEWy_bR8l75jfeDcpXQcRKVOmcml10NQLQ1F2UVvTgEnTKi0GO59dbCL/items/01VANVJQ2GE3EYXUX6NJEI6UWOKBM74MHA"
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationpowerpointresource

### Example 6: Create an educationMediaResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationMediaResource"
		displayName = "ModulePicture.PNG"
		fileUrl = "https://graph.microsoft.com/v1.0/drives/b!-Ik2sRPLDEWy_bR8l75jfeDcpXQcRKVOmcml10NQLQ1F2UVvTgEnTKi0GO59dbCL/items/01VANVJQ56XC3M4V7F5JEK3NLECZH4HWGP"
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationmediaresource

### Example 7: Create an educationChannelResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationChannelResource"
		url = "https://graph.microsoft.com/v1.0/teams/37d99af7-cfc5-4e3b-8566-f7d40e4a2070/channels/19:4gSkXJRlsCMnZvBzAcyXGdsGtcQV0AJWtfvQp_a6Fi81@thread.tacv2"
		displayName = "General"
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationchannelresource

### Example 8: Create an educationLinkedAssignmentResource

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		"@odata.type" = "#microsoft.graph.educationLinkedAssignmentResource"
		displayName = "2024-01-19T17_54_38_711Z"
		url = "https://graph.microsoft.com/v1.0/education/classes/37d99af7-cfc5-4e3b-8566-f7d40e4a2070/assignments/b6a1d277-fed7-4345-940e-3f2ce13eb737"
	}
}

New-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example will create an educationlinkedassignmentresource

