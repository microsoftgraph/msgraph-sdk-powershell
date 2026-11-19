### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	contentInfo = @{
		format = "default"
		identifier = "MyDoc.docx"
		state = "rest"
		metadata = @(
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Enabled"
				value = "True"
			}
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Method"
				value = "Standard"
			}
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_SetDate"
				value = "1/1/0001 12:00:00 AM"
			}
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_SiteId"
				value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Name"
				value = "LabelScopedToBob_Tests"
			}
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_ContentBits"
				value = "0"
			}
			@{
				name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_ActionId"
				value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
}

Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel -UserId $userId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel Cmdlet.

