### Example 1: Provision users from Microsoft Entra ID to third-party applications

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	parameters = @(
		@{
			subjects = @(
				@{
					objectId = "9bb0f679-a883-4a6f-8260-35b491b8b8c8"
					objectTypeName = "User"
				}
			)
			ruleId = "ea807875-5618-4f0a-9125-0b46a05298ca"
		}
	)
}

New-MgBetaServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params

```
This example will provision users from microsoft entra id to third-party applications

### Example 2: Sync on-demand from Active Directory to Microsoft Entra ID (Microsoft Entra Cloud Sync)

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	parameters = @(
		@{
			ruleId = "6c409270-f78a-4bc6-af23-7cf3ab6482fe"
			subjects = @(
				@{
					objectId = "CN=AdeleV,CN=Users,DC=corp,DC=chicago,DC=com"
					objectTypeName = "user"
				}
			)
		}
	)
}

New-MgBetaServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params

```
This example will sync on-demand from active directory to microsoft entra id (microsoft entra cloud sync)

### Example 3: Provision a group and two of its members on demand

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	parameters = @(
		@{
			ruleId = "33f7c90d-bf71-41b1-bda6-aaf0ddbee5d8#V2"
			subjects = @(
				@{
					objectId = "8213fd99-d6b6-417b-8e13-af6334856215"
					objectTypeName = "Group"
					links = @{
						members = @(
							@{
								objectId = "cbc86211-6ada-4803-b73f-8039cf56d8a2"
								objectTypeName = "User"
							}
							@{
								objectId = "2bc86211-6ada-4803-b73f-8039cf56d8a2"
								objectTypeName = "User"
							}
						)
					}
				}
			)
		}
	)
}

New-MgBetaServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params

```
This example will provision a group and two of its members on demand

