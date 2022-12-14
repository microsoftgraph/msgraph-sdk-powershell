### Example 1: Require MFA to access Exchange Online outside of trusted locations

```powershell
Connect-MgBetaGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'


$params = @{
  DisplayName = "Access to EXO requires MFA"
  State = "enabled"
  Conditions = @{
    ClientAppTypes = @(
      "mobileAppsAndDesktopClients"
      "browser"
    )
    Applications = @{
      IncludeApplications = @(
        "b457cbac-03cb-4b15-9eef-79f24f8d3247"
      )
    }
    Users = @{
      IncludeGroups = @(
        "f39e2655-3fae-43ad-94e2-c2b593cfc473"
       )
    }
    Locations = @{
      IncludeLocations = @(
        "All"
      )
      ExcludeLocations = @(
        "AllTrusted"
      )
    }
   }
   GrantControls = @{
     Operator = "OR"
     BuiltInControls = @(
       "mfa"
     )
   }
}

New-MgBetaIdentityConditionalAccessPolicy -BodyParameter $params

Id                                   CreatedDateTime      Description DisplayName                ModifiedDateTime State
--                                   ---------------      ----------- -----------                ---------------- -----
1c9afd06-3f59-464e-a6d9-193d99764a01 7/29/2022 9:46:18 AM             Access to EXO requires MFA                  enabled
```

This example shows a request to require multi-factor authentication for access to Exchange Online from modern authentication clients outside of trusted locations for a particular group.

### Example 2: Block access to Exchange Online from non-trusted regions

```powershell
Connect-MgBetaGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

$params = @{
  DisplayName = "Block access to EXO non-trusted regions."
  State = "enabled"
  Conditions = @{
    ClientAppTypes = @(
      "all"
    )
    Applications = @{
      IncludeApplications = @(
        "b457cbac-03cb-4b15-9eef-79f24f8d3247"
      )
    }
    Users = @{
      IncludeGroups = @(
        "f39e2655-3fae-43ad-94e2-c2b593cfc473"
      )
    }
    Locations = @{
      IncludeLocations = @(
        "0824dbaf-6277-4db0-8112-b29fd356f2c4"
      )
    }
  }
  GrantControls = @{
    Operator = "OR"
    BuiltInControls = @(
      "block"
    )
    }
  }

New-MgBetaIdentityConditionalAccessPolicy -BodyParameter $params

Id                                   CreatedDateTime       Description DisplayName                              ModifiedDateTime State
--                                   ---------------       ----------- -----------                              ---------------- -----
61c7530f-5c1d-44b2-a972-4ae658b7a9ac 7/29/2022 10:03:30 AM             Block access to EXO non-trusted regions.                  enabled

```

This example shows a request to block access to Exchange Online from non-trusted/unknown regions. This example assumes that the named location `0824dbaf-6277-4db0-8112-b29fd356f2c4` corresponds to a list of non-trusted/unknown regions.
