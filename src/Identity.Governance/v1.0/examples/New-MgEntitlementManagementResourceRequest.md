### Example 1: Create an accessPackageResourceRequest for adding a group as a resource

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminAdd"
	resource = @{
		displayName = "Test group"
		originId = "8ab659d0-3839-427d-8c54-5ae92f0b3e2e"
		originSystem = "AadGroup"
	}
	catalog = @{
		id = "beedadfe-01d5-4025-910b-84abb9369997"
	}
}

New-MgEntitlementManagementResourceRequest -BodyParameter $params

```
This example will create an accesspackageresourcerequest for adding a group as a resource

### Example 2: Create an accessPackageResourceRequest for adding an application as a resource

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminAdd"
	resource = @{
		originId = "e81d7f57-0840-45e1-894b-f505c1bdcc1f"
		originSystem = "AadApplication"
	}
	catalog = @{
		id = "beedadfe-01d5-4025-910b-84abb9369997"
	}
}

New-MgEntitlementManagementResourceRequest -BodyParameter $params

```
This example will create an accesspackageresourcerequest for adding an application as a resource

### Example 3: Create an accessPackageResourceRequest for adding a SharePoint Online site as a resource

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminAdd"
	resource = @{
		originId = "https://microsoft.sharepoint.com/sites/Example"
		originSystem = "SharePointOnline"
	}
	catalog = @{
		id = "beedadfe-01d5-4025-910b-84abb9369997"
	}
}

New-MgEntitlementManagementResourceRequest -BodyParameter $params

```
This example will create an accesspackageresourcerequest for adding a sharepoint online site as a resource

### Example 4: Create an accessPackageResourceRequest for removing a resource

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminRemove"
	resource = @{
		id = "1d0bb962-5bb0-4b16-a488-fda7a788b9ec"
	}
	catalog = @{
		id = "beedadfe-01d5-4025-910b-84abb9369997"
	}
}

New-MgEntitlementManagementResourceRequest -BodyParameter $params

```
This example will create an accesspackageresourcerequest for removing a resource

### Example 5: Create an accessPackageResourceRequest for updating an application as a resource with attributes

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminUpdate"
	resource = @{
		originId = "e81d7f57-0840-45e1-894b-f505c1bdcc1f"
		originSystem = "AadApplication"
		attributes = @(
			@{
				destination = @{
					"@odata.type" = "microsoft.graph.accessPackageUserDirectoryAttributeStore"
				}
				name = "officeLocation"
				source = @{
					"@odata.type" = "#microsoft.graph.accessPackageResourceAttributeQuestion"
					question = @{
						"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
						sequence = 
						isRequired = $true
						isAnswerEditable = $true
						text = "What office do you work at?"
						isSingleLineQuestion = $true
						regexPattern = "[a-zA-Z]+[a-zA-Z\s]*"
					}
				}
			}
			@{
				destination = @{
					"@odata.type" = "microsoft.graph.accessPackageUserDirectoryAttributeStore"
				}
				name = "extension_e409fedc08ab4807a9eb53ebc0d6cc9f_Expense_CostCenter"
				source = @{
					"@odata.type" = "#microsoft.graph.accessPackageResourceAttributeQuestion"
					question = @{
						"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
						isRequired = $false
						text = "What is your cost center number?"
						sequence = 
						isSingleLineQuestion = $true
						regexPattern = "[0-9]*"
					}
				}
			}
		)
	}
	catalog = @{
		id = "beedadfe-01d5-4025-910b-84abb9369997"
	}
}

New-MgEntitlementManagementResourceRequest -BodyParameter $params

```
This example will create an accesspackageresourcerequest for updating an application as a resource with attributes

