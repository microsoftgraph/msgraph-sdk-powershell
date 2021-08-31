### Example 1: Assign an app role to a group

```powershell
$appRoleAssignment = @{
  "principalId"= "f07a8d78-f18c-4c02-b339-9ebace025122"
  "resourceId"= "1c48f923-4fbb-4d37-b772-4d577eefec9e"
  "appRoleId"= "00000000-0000-0000-0000-000000000000"
  }

New-MgGroupAppRoleAssignment -GroupId 'f07a8d78-f18c-4c02-b339-9ebace025122' -BodyParameter $appRoleAssignment | 
  Format-List

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 8/19/2021 11:25:25 AM
DeletedDateTime      :
Id                   : eI168IzxAkyzOZ66zgJRIqVVeeA1CVFKmaBn-MGn0Bw
PrincipalDisplayName : All Employees
PrincipalId          : f07a8d78-f18c-4c02-b339-9ebace025122
PrincipalType        : Group
ResourceDisplayName  : Office 365 SharePoint Online
ResourceId           : 1c48f923-4fbb-4d37-b772-4d577eefec9e
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#groups('f07a8d78-f18c-4c02-b339-9ebace025122')/appRoleAssignments/$entity], [@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-
                       b10d-14f1195d665f/directoryObjects/$/Microsoft.DirectoryServices.Group('f07a8d78-f18c-4c02-b339-9ebace025122')/appRoleAssignments/eI168IzxAkyzOZ66zgJRIqVVeeA1CVFKmaBn-MGn0Bw]}
```

In this example, the first command creates the `$appRoleAssignment` variable that defines the following:

-`principalId`: The id of the group to which you are assigning the app role.

-`resourceId`: The id of the resource servicePrincipal which has defined the app role.

-`appRoleId`: The id of the appRole (defined on the resource service principal) to assign to the group. 

Learn more about the [AppRoleAssignment resource](/graph/api/resources/approleassignment?view=graph-rest-1.0).

The second command adds the role to the specified group.
