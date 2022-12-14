### Example 1: Get a list of all named locations

```powershell
Connect-MgBetaGraph -Scopes 'Policy.Read.All'
Get-MgBetaIdentityConditionalAccessNamedLocation

Id                                   CreatedDateTime       DisplayName                 ModifiedDateTime
--                                   ---------------       -----------                 ----------------
1b43b630-dbef-4cb7-afe5-fa4e113ea6b2 4/21/2022 10:28:22 AM KOs                         6/13/2022 8:23:06 AM
1f0fd623-bf8f-4003-9627-32a68c3cdcc1 6/13/2022 8:27:35 AM  Updated named location      6/13/2022 8:54:24 AM
0824dbaf-6277-4db0-8112-b29fd356f2c4 6/13/2022 8:41:38 AM  Untrusted IP named location 6/13/2022 8:41:38 AM
```

This example lists all existing named location rules.

### Example 2: Get a named location by Id

```powershell
Connect-MgBetaGraph -Scopes 'Policy.Read.All'
Get-MgBetaIdentityConditionalAccessNamedLocation -NamedLocationId '1f0fd623-bf8f-4003-9627-32a68c3cdcc1'

Id                                   CreatedDateTime      DisplayName            ModifiedDateTime
--                                   ---------------      -----------            ----------------
1f0fd623-bf8f-4003-9627-32a68c3cdcc1 6/13/2022 8:27:35 AM Updated named location 6/13/2022 8:54:24 AM
```

This example gets the named location rule by Id.
