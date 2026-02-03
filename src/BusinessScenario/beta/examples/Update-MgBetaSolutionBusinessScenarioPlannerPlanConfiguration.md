### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.BusinessScenario

$params = @{
	defaultLanguage = "en-us"
	buckets = @(
		@{
			externalBucketId = "deliveryBucket"
		}
		@{
			externalBucketId = "storePickupBucket"
		}
		@{
			externalBucketId = "specialOrdersBucket"
		}
		@{
			externalBucketId = "returnProcessingBucket"
		}
	)
	localizations = @(
		@{
			id = "en-us"
			languageTag = "en-us"
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
		@{
			id = "es-es"
			languageTag = "es-es"
			planTitle = "Seguimiento de pedidos"
			buckets = @(
				@{
					externalBucketId = "deliveryBucket"
					name = "Entregas"
				}
				@{
					externalBucketId = "storePickupBucket"
					name = "Recogida"
				}
				@{
					externalBucketId = "specialOrdersBucket"
					name = "Pedidos especiales"
				}
				@{
					externalBucketId = "specialOrdersBucket"
					name = "Devoluciones de clientes"
				}
			)
		}
	)
}

Update-MgBetaSolutionBusinessScenarioPlannerPlanConfiguration -BusinessScenarioId $businessScenarioId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSolutionBusinessScenarioPlannerPlanConfiguration Cmdlet.

