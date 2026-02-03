### Example 1: Update a country named location by adding to the list of countries

```powershell
Connect-MgGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

$params = @{
"@odata.type" = "#microsoft.graph.countryNamedLocation"
DisplayName = "Named location with unknown countries and regions"
CountriesAndRegions = @(
    "US"
    "XK"
    "ID"
    "CA"
)
IncludeUnknownCountriesAndRegions = $true
}

Update-MgIdentityConditionalAccessNamedLocation -NamedLocationId '1f0fd623-bf8f-4003-9627-32a68c3cdcc1' -BodyParameter $params
```

This example updates the details of an existing named location. Supply the values of the relevant fields that should be updated. In this example, `ID` and `CA` are added in the list of countries.
