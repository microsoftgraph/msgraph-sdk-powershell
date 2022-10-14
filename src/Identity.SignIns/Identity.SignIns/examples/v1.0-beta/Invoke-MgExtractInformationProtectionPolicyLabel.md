### Example 1: Using the Invoke-MgExtractInformationProtectionPolicyLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	ContentInfo = @{
		"@odata.type" = "#microsoft.graph.contentInfo"
		"Format@odata.type" = "#microsoft.graph.contentFormat"
		Format = "default"
		Identifier = $null
		"State@odata.type" = "#microsoft.graph.contentState"
		State = "rest"
		"Metadata@odata.type" = "#Collection(microsoft.graph.keyValuePair)"
		Metadata = @(
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Enabled"
				Value = "True"
			}
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Method"
				Value = "Standard"
			}
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Name"
				Value = "Top Secret"
			}
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ContentBits"
				Value = "0"
			}
			@{
				"@odata.type" = "#microsoft.graph.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
}
Invoke-MgExtractInformationProtectionPolicyLabel -BodyParameter $params
```
This example shows how to use the Invoke-MgExtractInformationProtectionPolicyLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
