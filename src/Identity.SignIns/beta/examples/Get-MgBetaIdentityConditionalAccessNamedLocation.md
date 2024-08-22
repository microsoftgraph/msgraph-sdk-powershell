### Example 1: List all namedLocations

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessNamedLocation

```
This example will list all namedlocations

### Example 2: List all ipNamedLocations

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessNamedLocation -Filter "isof('microsoft.graph.ipNamedLocation')" 

```
This example will list all ipnamedlocations

### Example 3: List all namedLocations created after a certain date

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessNamedLocation -Filter "createdDateTime ge 2019-09-01T00:00:00Z" 

```
This example will list all namedlocations created after a certain date

### Example 4: List all countryNamedLocations containing a certain country or region

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessNamedLocation -Filter "microsoft.graph.countryNamedLocation/countriesAndRegions/any(c: c eq 'CA')" 

```
This example will list all countrynamedlocations containing a certain country or region

### Example 5: List all compliantNetworkNamedLocations

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessNamedLocation -Filter "isof('microsoft.graph.compliantNetworkNamedLocation')" 

```
This example will list all compliantnetworknamedlocations

