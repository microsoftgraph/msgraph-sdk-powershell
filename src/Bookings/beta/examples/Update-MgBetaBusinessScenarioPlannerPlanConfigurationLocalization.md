### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.plannerPlanConfigurationLocalization"
	planTitle = "Order Tracking"
	buckets = @(
		@{
			externalBucketId = "deliveryBucket"
			name = "Deliveries"
		}
		@{
			externalBucketId = "storePickupBucket"
			name = "Pickup"
		}
		@{
			externalBucketId = "specialOrdersBucket"
			name = "Special Orders"
		}
		@{
			externalBucketId = "returnProcessingBucket"
			name = "Customer Returns"
		}
	)
}

Update-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId $businessScenarioId -PlannerPlanConfigurationLocalizationId $plannerPlanConfigurationLocalizationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization Cmdlet.

