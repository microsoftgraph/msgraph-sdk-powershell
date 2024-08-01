### Example 1: Create an onTokenIssuanceStartListener object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onTokenIssuanceStartListener"
	conditions = @{
		applications = @{
			includeAllApplications = $false
			includeApplications = @(
				@{
					appId = "a13d0fc1-04ab-4ede-b215-63de0174cbb4"
				}
			)
		}
	}
	priority = 500
	handler = @{
		"@odata.type" = "#microsoft.graph.onTokenIssuanceStartCustomExtensionHandler"
		customExtension = @{
			id = "6fc5012e-7665-43d6-9708-4370863f4e6e"
		}
	}
}

New-MgBetaIdentityAuthenticationEventListener -BodyParameter $params

```
This example will create an ontokenissuancestartlistener object

### Example 2: Create an onAttributeCollectionStartListener object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onAttributeCollectionStartListener"
	priority = 500
	conditions = @{
		applications = @{
			includeAllApplications = $false
			includeApplications = @(
				@{
					appId = "a7eed01f-a333-4983-bc6b-d359ec9e5eef"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionStartCustomExtensionHandler"
		customExtension = @{
			id = "2d9c3e8d-88a9-444e-8c4c-f0c6c4fe1c02"
		}
	}
}

New-MgBetaIdentityAuthenticationEventListener -BodyParameter $params

```
This example will create an onattributecollectionstartlistener object

### Example 3: Create an onAttributeCollectionSubmitListener object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onAttributeCollectionSubmitListener"
	priority = 500
	conditions = @{
		applications = @{
			includeAllApplications = $false
			includeApplications = @(
				@{
					appId = "a7eed01f-a333-4983-bc6b-d359ec9e5eef"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionSubmitCustomExtensionHandler"
		customExtension = @{
			id = "66867d1f-7824-4f38-aad1-75da1ad09ee2"
		}
	}
}

New-MgBetaIdentityAuthenticationEventListener -BodyParameter $params

```
This example will create an onattributecollectionsubmitlistener object

