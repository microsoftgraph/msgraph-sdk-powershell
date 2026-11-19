### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	contentInfo = @{
		"@odata.type" = "#microsoft.graph.security.contentInfo"
		identifier = $null
		state = "rest"
		metadata = @(
			@{
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Enabled"
				value = "True"
			}
			@{
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Method"
				value = "Standard"
			}
			@{
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SetDate"
				value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SiteId"
				value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Name"
				value = "LabelScopedToBob_Tests"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ContentBits"
				value = "0"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ActionId"
				value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
	downgradeJustification = @{
		justificationMessage = "The information has been declassified."
		isDowngradeJustified = $true
	}
}

Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval -UserId $userId -BodyParameter $params

```
This example shows how to use the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval Cmdlet.

