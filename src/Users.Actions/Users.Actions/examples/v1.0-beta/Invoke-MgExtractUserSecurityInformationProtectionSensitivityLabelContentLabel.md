### Example 1: Using the Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	ContentInfo = @{
		Format = "default"
		Identifier = "MyDoc.docx"
		State = "rest"
		Metadata = @(
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Enabled"
				Value = "True"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Method"
				Value = "Standard"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Name"
				Value = "LabelScopedToBob_Tests"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_ContentBits"
				Value = "0"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
}
Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel -UserId $userId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
