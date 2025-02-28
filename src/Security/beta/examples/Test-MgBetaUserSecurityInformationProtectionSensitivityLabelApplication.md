### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	contentInfo = @{
		"@odata.type" = "#microsoft.graph.security.contentInfo"
		"format@odata.type" = "#microsoft.graph.security.contentFormat"
		contentFormat = "File"
		format = "default"
		identifier = $null
		"state@odata.type" = "#microsoft.graph.security.contentState"
		state = "rest"
		"metadata@odata.type" = "#Collection(microsoft.graph.security.keyValuePair)"
		metadata = @(
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_Enabled"
				value = "True"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_Method"
				value = "Standard"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_SetDate"
				value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_SiteId"
				value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_Name"
				value = "LabelScopedToBob_Tests"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_ContentBits"
				value = "0"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_ActionId"
				value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
	labelingOptions = @{
		"@odata.type" = "#microsoft.graph.security.labelingOptions"
		"assignmentMethod@odata.type" = "#microsoft.graph.security.assignmentMethod"
		assignmentMethod = "standard"
		"labelId@odata.type" = "#Guid"
		labelId = "836ff34f-b604-4a62-a68c-d6be4205d569"
		downgradeJustification = @{
			justificationMessage = "Justified"
			isDowngradeJustified = $true
		}
		"extendedProperties@odata.type" = "#Collection(microsoft.graph.security.keyValuePair)"
		extendedProperties = @(
		)
	}
}

Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication -UserId $userId -BodyParameter $params

```
This example shows how to use the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication Cmdlet.

