### Example 1: Using the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	ContentInfo = @{
		"@odata.type" = "#microsoft.graph.security.contentInfo"
		"Format@odata.type" = "#microsoft.graph.security.contentFormat"
		ContentFormat = "File"
		Format = "default"
		Identifier = $null
		"State@odata.type" = "#microsoft.graph.security.contentState"
		State = "rest"
		"Metadata@odata.type" = "#Collection(microsoft.graph.security.keyValuePair)"
		Metadata = @(
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_Enabled"
				Value = "True"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_Method"
				Value = "Standard"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_Name"
				Value = "LabelScopedToBob_Tests"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_ContentBits"
				Value = "0"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_3a80e051-487c-40d4-b491-73ad25d997e6_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
	LabelingOptions = @{
		"@odata.type" = "#microsoft.graph.security.labelingOptions"
		"AssignmentMethod@odata.type" = "#microsoft.graph.security.assignmentMethod"
		AssignmentMethod = "standard"
		"LabelId@odata.type" = "#Guid"
		LabelId = "836ff34f-b604-4a62-a68c-d6be4205d569"
		DowngradeJustification = @{
			JustificationMessage = "Justified"
			IsDowngradeJustified = $true
		}
		"ExtendedProperties@odata.type" = "#Collection(microsoft.graph.security.keyValuePair)"
		ExtendedProperties = @(
		)
	}
}
Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication -UserId $userId -BodyParameter $params
```
This example shows how to use the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
