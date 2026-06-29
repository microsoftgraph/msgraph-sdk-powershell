### Example 1: Get all access package suggestions with default insight types

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterEntitlementManagementAccessPackageSuggestionByCurrentUser -ExpandProperty "availableAccessPackage"  -On $onId 

```
This example will get all access package suggestions with default insight types

### Example 2: Get access package suggestions based on assignment history

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterEntitlementManagementAccessPackageSuggestionByCurrentUser -ExpandProperty "availableAccessPackage"  -On $onId 

```
This example will get access package suggestions based on assignment history

