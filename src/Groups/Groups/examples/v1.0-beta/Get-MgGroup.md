### Example 1: Get a list of groups

```powershell
Get-MgGroup | 
  Format-List Id, DisplayName, Description, GroupTypes

Id          : 0a1c8435-40a3-4a72-8586-e916c12b613a
DisplayName : Marketing
Description : A group to synthesize, analyze, and synchronize our marketing efforts.
GroupTypes  : {Unified}

Id          : a8fbb1b5-b994-4835-9183-c7421d149132
DisplayName : Business Development
Description : Welcome to the BizDev team.
GroupTypes  : {Unified}
```

This examples retrieves a list of groups.

### Example 2: Get a group by the display name

```powershell
Get-MgGroup -Filter "DisplayName eq 'Business Development'" | 
  Format-List Id, DisplayName, Description, GroupTypes

Id          : a8fbb1b5-b994-4835-9183-c7421d149132
DisplayName : Business Development
Description : Welcome to the BizDev team.
GroupTypes  : {Unified}
```

This example gets a group by the specified display name.