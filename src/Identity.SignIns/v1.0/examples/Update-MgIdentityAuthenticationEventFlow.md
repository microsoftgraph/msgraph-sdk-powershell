### Example 1: Update the display name of an external identities self-service sign-up user flow

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	displayName = "New user flow description"
}

Update-MgIdentityAuthenticationEventFlow -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example will update the display name of an external identities self-service sign-up user flow

### Example 2: Update the page layout of a self-service sign up user flow

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	onAttributeCollection = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp"
		attributeCollectionPage = @{
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
							required = $true
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
							required = $true
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
							options = @(
							)
						}
						@{
							attribute = "extension_331d514c0c18477583ea7dd5a79feda2_RockorCountry"
							label = "Rock music or Country"
							inputType = "radioSingleSelect"
							defaultValue = $null
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $true
							validationRegEx = "^.*"
							options = @(
								@{
									label = "Rock music"
									value = "Rock"
								}
								@{
									label = "Country music"
									value = "Country"
								}
							)
						}
					)
				}
			)
		}
	}
}

Update-MgIdentityAuthenticationEventFlow -AuthenticationEventsFlowId $authenticationEventsFlowId -BodyParameter $params

```
This example will update the page layout of a self-service sign up user flow

