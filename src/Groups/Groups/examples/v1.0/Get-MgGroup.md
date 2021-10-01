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

### Example 3: Get a count of all groups

```powershell
Get-MgGroup -ConsistencyLevel eventual -Count groupCount

Id                                   DisplayName          Description                                                            GroupTypes          AccessType
--                                   -----------          -----------                                                            ----------          ----------
0260d811-6674-4e65-9674-f511abcb4f7b Tailspin Toys Ltd                                                                           {}
0d5832d1-536d-4c5d-9435-e57413d9167f Test Group 1         This is a test group                                                   {}
0e06b38f-931a-47db-9a9a-60ab5f492005 Executives                                                                                  {}
1cb7317c-9c49-4dc8-a358-67ad8e95217c Finance Team                                                                                {}
2692d278-8323-4094-b286-e0ffce5e54a5 Marketing            A group to synthesize, analyze, and synchronize our marketing efforts. {Unified}
300a5486-9c58-422f-97a0-d2453977bcec Marketing resources  Marketing resources                                                    {}
4d5f57a1-85e0-41dd-8282-ff995ad5e1c3 Business Development Welcome to the BizDev team.                                            {Unified}
```

The example gets a list of all groups. The $groupCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

### Example 4: Use -Search to get all the groups whose display name contains 'Market' including a count of the returned users

```powershell
Get-MgGroup -ConsistencyLevel eventual -Count groupCount -Search '"DisplayName:Market"'

Id                                   DisplayName         Description                                                            GroupTypes AccessType
--                                   -----------         -----------                                                            ---------- ----------
2692d278-8323-4094-b286-e0ffce5e54a5 Marketing           A group to synthesize, analyze, and synchronize our marketing efforts. {Unified}
300a5486-9c58-422f-97a0-d2453977bcec Marketing resources Marketing resources                                                    {}
74a7bfca-7fbc-4a67-b4bb-3ef115b114f1 Sales & Marketing   This is the sales and marketing team                                   {}
```

This example returns all groups whose display name contains 'Market'. The $groupCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

### Example 5: Use -Filter to get all the applications with a display name that starts with 'A' including a count of the returned users, with the results ordered by display name

```powershell
Get-MgGroup -ConsistencyLevel eventual -Count groupCount -Filter "startsWith(DisplayName, 'A')" -OrderBy DisplayName

Id                                   DisplayName   Description                                           GroupTypes          AccessType
--                                   -----------   -----------                                           ----------          ----------
7fbcfd32-d930-4968-aa42-924bf462a305 All Company   This is the default group for everyone in the network {Unified}
f07a8d78-f18c-4c02-b339-9ebace025122 All Employees                                                       {}
bbfa9226-a965-47e1-9db2-bcfcb2c202e6 All Users
```

This example returns all groups whose display name starts with 'A'. The $groupCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).
