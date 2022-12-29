### Example 1: Using the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	ContentInfo = @{
		"@odata.type" = "#microsoft.graph.security.contentInfo"
		Identifier = $null
		State = "rest"
		Metadata = @(
			@{
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Enabled"
				Value = "True"
			}
			@{
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Method"
				Value = "Standard"
			}
			@{
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Name"
				Value = "LabelScopedToBob_Tests"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ContentBits"
				Value = "0"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
	DowngradeJustification = @{
		JustificationMessage = "The information has been declassified."
		IsDowngradeJustified = $true
	}
}
Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval -UserId $userId -BodyParameter $params
```
This example shows how to use the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
