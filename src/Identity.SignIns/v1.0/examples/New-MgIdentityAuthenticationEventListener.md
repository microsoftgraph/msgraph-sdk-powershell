### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onTokenIssuanceStartListener"
	conditions = @{
		applications = @{
			includeApplications = @(
				@{
					appId = "a13d0fc1-04ab-4ede-b215-63de0174cbb4"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onTokenIssuanceStartCustomExtensionHandler"
		customExtension = @{
			id = "6fc5012e-7665-43d6-9708-4370863f4e6e"
		}
	}
}

New-MgIdentityAuthenticationEventListener -BodyParameter $params

```
This example shows how to use the New-MgIdentityAuthenticationEventListener Cmdlet.

