### Example 1: AWS policy request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	requestedPermissions = @{
		"@odata.type" = "#microsoft.graph.awsPermissionsDefinition"
		authorizationSystemInfo = @{
			authorizationSystemId = "956987887735"
			authorizationSystemType = "AWS"
		}
		actionInfo = @{
			"@odata.type" = "microsoft.graph.awsPolicyPermissionsDefinitionAction"
			policies = @(
				@{
					id = "arn:aws:iam::956987887735:policy/AddUserToGroup"
				}
			)
			assignToRoleId = "arn:aws:aim::956987887735:role/saml-user"
		}
		identityInfo = @{
			externalId = "alex@contoso.com"
			source = @{
				"@odata.type" = "microsoft.graph.samlIdentitySource"
			}
			identityType = "user"
		}
	}
	justification = "I need to do this because I want to add a user to a group"
	notes = "Pretty Please"
	scheduleInfo = @{
		expiration = @{
			duration = "PT1H"
		}
	}
	ticketInfo = @{
		ticketNumber = "INC1234567"
		ticketSystem = "ServiceNow"
		ticketSubmitterIdentityId = "alex@contoso.com"
		ticketApproverIdentityId = "alexmanager@contoso.com"
	}
}

New-MgBetaIdentityGovernancePermissionManagementScheduledPermissionRequest -BodyParameter $params

```
This example will aws policy request

### Example 2: Azure roles request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	requestedPermissions = @{
		"@odata.type" = "microsoft.graph.singleResourceAzurePermissionsDefinition"
		authorizationSystemInfo = @{
			authorizationSystemId = "87eefd90-95a3-480a-ba42-56ff299a05ee"
			authorizationSystemType = "AZURE"
		}
		actionInfo = @{
			"@odata.type" = "microsoft.graph.azureRolePermissionsDefinitionAction"
			roles = @(
				@{
					id = "cdda3590-29a3-44f6-95f2-9f980659eb04"
				}
				@{
					id = "312a565d-c81f-4fd8-895a-4e21e48d571c"
				}
			)
		}
		identityInfo = @{
			externalId = "alex@contoso.com"
			source = @{
				"@odata.type" = "microsoft.graph.edIdentitySource"
			}
			identityType = "user"
		}
		resourceId = "/subscriptions/87eefd90-95a3-480a-ba42-56ff299a05ee"
	}
	justification = "I need to do this because I want to some new azure roles"
	notes = "Pretty Pleaseeeee"
	scheduleInfo = @{
		expiration = @{
			duration = "PT1H"
		}
		recurrence = $null
	}
	ticketInfo = @{
		ticketNumber = "INC1234567"
		ticketSystem = "ServiceNow"
		ticketSubmitterIdentityId = "alex@contoso.com"
		ticketApproverIdentityId = "alexmanager@contoso.com"
	}
}

New-MgBetaIdentityGovernancePermissionManagementScheduledPermissionRequest -BodyParameter $params

```
This example will azure roles request

### Example 3: GCP actions request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	requestedPermissions = @{
		"@odata.type" = "microsoft.graph.singleResourceGcpPermissionsDefinition"
		authorizationSystemInfo = @{
			authorizationSystemId = "carbide-bonsai-205017"
			authorizationSystemType = "GCP"
		}
		actionInfo = @{
			"@odata.type" = "microsoft.graph.gcpActionPermissionsDefinitionAction"
			actions = @(
			"aiplatform:dataitems"
		)
	}
	identityInfo = @{
		externalId = "alex@contoso.com"
		source = @{
			"@odata.type" = "microsoft.graph.edIdentitySource"
		}
		identityType = "user"
	}
	resourceId = "carbide-bonsai-205017"
}
justification = "I need to do this because I want to code my own chat GPT-3 bot on GCP"
notes = "Pretty Pleaseeeee"
scheduleInfo = @{
	expiration = @{
		duration = "PT1H"
	}
}
ticketInfo = @{
	ticketNumber = "INC1234567"
	ticketSystem = "ServiceNow"
	ticketSubmitterIdentityId = "alex@contoso.com"
	ticketApproverIdentityId = "alexmanager@contoso.com"
}
}

New-MgBetaIdentityGovernancePermissionManagementScheduledPermissionRequest -BodyParameter $params

```
This example will gcp actions request

