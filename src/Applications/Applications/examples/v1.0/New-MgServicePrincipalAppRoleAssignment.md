### Example 1: {{ Add title here }}

```powershell
$appRoleAssignment = @{
  "principalId"= "0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61"
  "resourceId"= "557aedfc-007c-4904-918a-7e6fed2e7403"
  "appRoleId"= "00000000-0000-0000-0000-000000000000"
  }

New-MgServicePrincipalAppRoleAssignment -ServicePrincipalId 0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61 -BodyParameter $appRoleAssignment | Format-List

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/31/2021 2:01:28 PM
DeletedDateTime      :
Id                   : PRLbC6e4yUyMwr0XutBvYfZHkKGzlbxDr2I-QJWN9rs
PrincipalDisplayName : Example App
PrincipalId          : 0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61
PrincipalType        : ServicePrincipal
ResourceDisplayName  : Office 365 Management APIs
ResourceId           : 557aedfc-007c-4904-918a-7e6fed2e7403
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#servicePrincipals('0bdb123d-b8a7-4cc9-8cc2-bd17
                       bad06f61')/appRoleAssignments/$entity], [@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-b10d-1
                       4f1195d665f/directoryObjects/$/Microsoft.DirectoryServices.ServicePrincipal('0bdb123d-b8a7-4cc9-8cc2-bd17bad
                       06f61')/appRoleAssignments/PRLbC6e4yUyMwr0XutBvYfZHkKGzlbxDr2I-QJWN9rs]}
```

In this example, the first command defines the `$appRoleAssignment` variable that defines the following:

-`principalId`: The id of the client service principal to which you are assigning the app role.

-`resourceId`: The id of the resource `servicePrincipal` (the API) which has defined the app role (the application permission).

-`appRoleId`: The id of the appRole (defined on the resource service principal) to assign to the client service principal. 

Learn more about the [AppRoleAssignment resource](/graph/api/resources/approleassignment?view=graph-rest-1.0).

The second command adds the role to the specified service principal.
