### Example 1: Update the display name and priority of an authenticationEventsFlow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	displayName = "New user flow description"
	priority = 200
}

Update-MgBetaIdentityAuthenticationEventFlow -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example will update the display name and priority of an authenticationeventsflow

### Example 2: Update the onAttributeCollection event of a self-service sign up user flow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	onAttributeCollection = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp"
		attributeCollectionPage = @{
			customStringsFileId = $null
			views = @(
				@{
					title = $null
					description = $null
					inputs = @(
						@{
							attribute = "email"
							label = "Email Address"
							inputType = "text"
							defaultValue = $null
							hidden = $true
							editable = $false
							writeToDirectory = $true
							required = $true
							validationRegEx = "^[a-zA-Z0-9.!#$%&amp;&#8217;'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)*$"
							options = @(
							)
						}
						@{
							attribute = "displayName"
							label = "Display Name"
							inputType = "text"
							defaultValue = $null
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
							options = @(
							)
						}
						@{
							attribute = "city"
							label = "City"
							inputType = "text"
							defaultValue = $null
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
							options = @(
							)
						}
						@{
							attribute = "extension_6ea3bc85aec24b1c92ff4a117afb6621_Favoritecolor"
							label = "Favorite color"
							inputType = "text"
							defaultValue = $null
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^.*"
							options = @(
							)
						}
					)
				}
			)
		}
	}
}

Update-MgBetaIdentityAuthenticationEventFlow -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example will update the onattributecollection event of a self-service sign up user flow

### Example 3: Remove an attribute collected during a self-service sign up user flow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	onAttributeCollection = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp"
		attributeCollectionPage = @{
			customStringsFileId = $null
			views = @(
				@{
					title = $null
					description = $null
					inputs = @(
						@{
							attribute = "email"
							label = "Email Address"
							inputType = "text"
							defaultValue = $null
							hidden = $true
							editable = $false
							writeToDirectory = $true
							required = $true
							validationRegEx = "^[a-zA-Z0-9.!#$%&amp;&#8217;'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)*$"
							options = @(
							)
						}
						@{
							attribute = "displayName"
							label = "Display Name"
							inputType = "text"
							defaultValue = $null
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
							options = @(
							)
						}
						@{
							attribute = "extension_6ea3bc85aec24b1c92ff4a117afb6621_Favoritecolor"
							label = "Favorite color"
							inputType = "text"
							defaultValue = $null
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^.*"
							options = @(
							)
						}
					)
				}
			)
		}
	}
}

Update-MgBetaIdentityAuthenticationEventFlow -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example will remove an attribute collected during a self-service sign up user flow

