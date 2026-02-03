### Example 1: Create a basic External Identities sign-up and sign-in user flow in an external tenant

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	displayName = "Woodgrove Drive User Flow"
	onAuthenticationMethodLoadStart = @{
		"@odata.type" = "#microsoft.graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp"
		identityProviders = @(
			@{
				id = "EmailPassword-OAUTH"
			}
		)
	}
	onInteractiveAuthFlowStart = @{
		"@odata.type" = "#microsoft.graph.onInteractiveAuthFlowStartExternalUsersSelfServiceSignUp"
		isSignUpAllowed = $true
	}
	onAttributeCollection = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp"
		attributes = @(
			@{
				id = "email"
				displayName = "Email Address"
				description = "Email address of the user"
				userFlowAttributeType = "builtIn"
				dataType = "string"
			}
			@{
				id = "displayName"
				displayName = "Display Name"
				description = "Display Name of the User."
				userFlowAttributeType = "builtIn"
				dataType = "string"
			}
		)
		attributeCollectionPage = @{
			views = @(
				@{
					inputs = @(
						@{
							attribute = "email"
							label = "Email Address"
							inputType = "Text"
							hidden = $true
							editable = $false
							writeToDirectory = $true
							required = $true
							validationRegEx = "^[a-zA-Z0-9.!#$%&amp;&#8217;'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)*$"
						}
						@{
							attribute = "displayName"
							label = "Display Name"
							inputType = "text"
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
						}
					)
				}
			)
		}
	}
}

New-MgBetaIdentityAuthenticationEventFlow -BodyParameter $params

```
This example will create a basic external identities sign-up and sign-in user flow in an external tenant

### Example 2: Create a basic external identities sign-up and sign-in user flow with an attached application in an external tenant

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	displayName = "Woodgrove Drive User Flow"
	conditions = @{
		applications = @{
			includeApplications = @(
				@{
					appId = "63856651-13d9-4784-9abf-20758d509e19"
				}
			)
		}
	}
	onAuthenticationMethodLoadStart = @{
		"@odata.type" = "#microsoft.graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp"
		identityProviders = @(
			@{
				id = "EmailPassword-OAUTH"
			}
		)
	}
	onInteractiveAuthFlowStart = @{
		"@odata.type" = "#microsoft.graph.onInteractiveAuthFlowStartExternalUsersSelfServiceSignUp"
		isSignUpAllowed = $true
	}
	onAttributeCollection = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp"
		attributes = @(
			@{
				id = "email"
				displayName = "Email Address"
				description = "Email address of the user"
				userFlowAttributeType = "builtIn"
				dataType = "string"
			}
			@{
				id = "displayName"
				displayName = "Display Name"
				description = "Display Name of the User."
				userFlowAttributeType = "builtIn"
				dataType = "string"
			}
		)
		attributeCollectionPage = @{
			views = @(
				@{
					inputs = @(
						@{
							attribute = "email"
							label = "Email Address"
							inputType = "Text"
							hidden = $true
							editable = $false
							writeToDirectory = $true
							required = $true
							validationRegEx = "^[a-zA-Z0-9.!#$%&amp;&#8217;'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)*$"
						}
						@{
							attribute = "displayName"
							label = "Display Name"
							inputType = "text"
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
						}
					)
				}
			)
		}
	}
}

New-MgBetaIdentityAuthenticationEventFlow -BodyParameter $params

```
This example will create a basic external identities sign-up and sign-in user flow with an attached application in an external tenant

### Example 3: Create an External Identities sign-up and sign-in user flow with social providers and a custom attribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow"
	displayName = "Woodgrove User Flow 2"
	onAuthenticationMethodLoadStart = @{
		"@odata.type" = "#microsoft.graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp"
		identityProviders = @(
			@{
				id = "EmailPassword-OAUTH"
			}
			@{
				id = "Google-OAUTH"
			}
			@{
				id = "Facebook-OAUTH"
			}
		)
	}
	onInteractiveAuthFlowStart = @{
		"@odata.type" = "#microsoft.graph.onInteractiveAuthFlowStartExternalUsersSelfServiceSignUp"
		isSignUpAllowed = $true
	}
	onAttributeCollection = @{
		"@odata.type" = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp"
		attributes = @(
			@{
				id = "email"
				displayName = "Email Address"
				description = "Email address of the user"
				userFlowAttributeType = "builtIn"
				dataType = "string"
			}
			@{
				id = "displayName"
				displayName = "Display Name"
				description = "Display Name of the User."
				userFlowAttributeType = "builtIn"
				dataType = "string"
			}
			@{
				id = "extension_6ea3bc85aec24b1c92ff4a117afb6621_Favoritecolor"
				displayName = "Favorite color"
				description = "what is your favorite color"
				userFlowAttributeType = "custom"
				dataType = "string"
			}
		)
		attributeCollectionPage = @{
			views = @(
				@{
					inputs = @(
						@{
							attribute = "email"
							label = "Email Address"
							inputType = "Text"
							hidden = $true
							editable = $false
							writeToDirectory = $true
							required = $true
							validationRegEx = "^[a-zA-Z0-9.!#$%&amp;&#8217;'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)*$"
						}
						@{
							attribute = "displayName"
							label = "Display Name"
							inputType = "text"
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
						}
						@{
							attribute = "extension_6ea3bc85aec24b1c92ff4a117afb6621_Favoritecolor"
							label = "Favorite color"
							inputType = "text"
							hidden = $false
							editable = $true
							writeToDirectory = $true
							required = $false
							validationRegEx = "^[a-zA-Z_][0-9a-zA-Z_ ]*[0-9a-zA-Z_]+$"
						}
					)
				}
			)
		}
	}
}

New-MgBetaIdentityAuthenticationEventFlow -BodyParameter $params

```
This example will create an external identities sign-up and sign-in user flow with social providers and a custom attribute

