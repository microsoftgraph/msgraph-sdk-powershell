### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	activities = @(
		@{
			"@odata.type" = "#microsoft.graph.externalConnectors.externalActivity"
			type = "created"
			startDateTime = [System.DateTime]::Parse("2021-04-06T18:04:31.033Z")
			performedBy = @{
				type = "user"
				id = "1f0c997e-99f7-43f1-8cca-086f8d42be8d"
			}
		}
	)
}

Add-MgExternalConnectionItemActivity -ExternalConnectionId $externalConnectionId -ExternalItemId $externalItemId -BodyParameter $params

```
This example shows how to use the Add-MgExternalConnectionItemActivity Cmdlet.

