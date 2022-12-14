### Example 1: Create a country named location

```powershell
Connect-MgBetaGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

$params = @{
"@odata.type" = "#microsoft.graph.countryNamedLocation"
DisplayName = "Named location with unknown countries and regions"
CountriesAndRegions = @(
    "US"
    "XK"
)
IncludeUnknownCountriesAndRegions = $true
}

New-MgBetaIdentityConditionalAccessNamedLocation -BodyParameter $params

Id                                   CreatedDateTime      DisplayName                                       ModifiedDateTime
--                                   ---------------      -----------                                       ----------------
1f0fd623-bf8f-4003-9627-32a68c3cdcc1 6/13/2022 8:27:35 AM Named location with unknown countries and regions 6/13/2022 8:27:35 AM
```

This example creates a country named location.

### Example 2: Create an ip named location

```powershell
Connect-MgBetaGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

$params = @{
"@odata.type" = "#microsoft.graph.ipNamedLocation"
DisplayName = "Untrusted IP named location"
IsTrusted = $false
IpRanges = @(
    @{
        "@odata.type" = "#microsoft.graph.iPv4CidrRange"
        CidrAddress = "12.34.221.11/22"
    }
    @{
        "@odata.type" = "#microsoft.graph.iPv6CidrRange"
        CidrAddress = "2001:0:9d38:90d6:0:0:0:0/63"
    }
)
}

New-MgBetaIdentityConditionalAccessNamedLocation -BodyParameter $params

Id                                   CreatedDateTime      DisplayName                 ModifiedDateTime
--                                   ---------------      -----------                 ----------------
0824dbaf-6277-4db0-8112-b29fd356f2c4 6/13/2022 8:41:38 AM Untrusted IP named location 6/13/2022 8:41:38 AM
```

This example creates an Ip named location.
