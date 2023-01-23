### Example 1: Using the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Parameters = @(
		@{
			RuleId = "6c409270-f78a-4bc6-af23-7cf3ab6482fe"
			Subjects = @(
				@{
					ObjectId = "CN=AdeleV,CN=Users,DC=corp,DC=chicago,DC=com"
					ObjectTypeName = "user"
				}
			)
		}
	)
}
New-MgBetaServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Parameters = @(
		@{
			Subjects = @(
				@{
					ObjectId = "9bb0f679-a883-4a6f-8260-35b491b8b8c8"
					ObjectTypeName = "User"
				}
			)
			RuleId = "ea807875-5618-4f0a-9125-0b46a05298ca"
		}
	)
}
New-MgBetaServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Parameters = @(
		@{
			RuleId = "33f7c90d-bf71-41b1-bda6-aaf0ddbee5d8#V2"
			Subjects = @(
				@{
					ObjectId = "8213fd99-d6b6-417b-8e13-af6334856215"
					ObjectTypeName = "Group"
					Links = @{
						Members = @(
							@{
								ObjectId = "cbc86211-6ada-4803-b73f-8039cf56d8a2"
								ObjectTypeName = "User"
							}
							@{
								ObjectId = "2bc86211-6ada-4803-b73f-8039cf56d8a2"
								ObjectTypeName = "User"
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
This example shows how to use the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Parameters = @(
		@{
			Subjects = @(
				@{
					ObjectId = "9bb0f679-a883-4a6f-8260-35b491b8b8c8"
					ObjectTypeName = "User"
				}
			)
			RuleId = "ea807875-5618-4f0a-9125-0b46a05298ca"
		}
	)
}
New-MgBetaServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalSynchronizationJobOnDemand Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
