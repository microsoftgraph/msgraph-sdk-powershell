### Example 1: Get all application role assignments for a service principal

```powershell
Get-MgBetaServicePrincipalAppRoleAssignment -ServicePrincipalId '0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61' |  Format-List

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/31/2021 2:01:28 PM
DeletedDateTime      :
Id                   : PRLbC6e4yUyMwr0XutBvYfZHkKGzlbxDr2I-QJWN9rs
PrincipalDisplayName : Example App
PrincipalId          : 0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61
PrincipalType        : ServicePrincipal
ResourceDisplayName  : Office 365 Management APIs
ResourceId           : 557aedfc-007c-4904-918a-7e6fed2e7403
AdditionalProperties : {[@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-b10d-14f1195d665f/directoryObjects/$/Microsof
                       t.DirectoryServices.ServicePrincipal('0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61')/appRoleAssignments/PRLbC6e4yUyM
                       wr0XutBvYfZHkKGzlbxDr2I-QJWN9rs]}

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/31/2021 1:59:44 PM
DeletedDateTime      :
Id                   : PRLbC6e4yUyMwr0XutBvYZsr7FiAW3pIqP4F9944yBc
PrincipalDisplayName : Example App
PrincipalId          : 0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61
PrincipalType        : ServicePrincipal
ResourceDisplayName  : Office 365 SharePoint Online
ResourceId           : 1c48f923-4fbb-4d37-b772-4d577eefec9e
AdditionalProperties : {[@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-b10d-14f1195d665f/directoryObjects/$/Microsof
                       t.DirectoryServices.ServicePrincipal('0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61')/appRoleAssignments/PRLbC6e4yUyM
                       wr0XutBvYZsr7FiAW3pIqP4F9944yBc]}
```

This example gets the application role assignments that have been granted to the specified service principal.
