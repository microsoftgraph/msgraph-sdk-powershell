### Example 1: Get all service principals from the directory

```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaServicePrincipal

Id             : 304ae362-7953-4d08-8e15-aeece4d01017c
DisplayName    : IC3 Gateway TestClone
AppId          : 509ab5b8-1380-4906-9765-76d2ace9335d
SignInAudience : AzureADMultipleOrgs

Id             : 4297089a-3358-4bf5-92b0-a35fbdb2407c
DisplayName    : Microsoft Forms
AppId          : 67c93110-694e-4a54-b1af-d6cd2e3b12d7
SignInAudience : AzureADMultipleOrgs
```

This example retrieves all service principals from the directory.

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgBetaGraph -Scopes Permission`. For example, `Connect-MgBetaGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 2: Get the service principal by display name

```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaServicePrincipal -Filter "DisplayName eq 'Power BI Service'" | 
  Format-List Id, DisplayName,AppId, SignInAudience

Id             : 9518fb8f-8d9e-4aae-be20-d398f9cc59ac
DisplayName    : Power BI Service
AppId          : 60dbf324-9702-41cc-a5fa-f8d19804b014
SignInAudience : AzureADMultipleOrgs
```

This example gets the service principal by display name.

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgBetaGraph -Scopes Permission`. For example, `Connect-MgBetaGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 3: Get a count of the service principals

```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaServicePrincipal -ConsistencyLevel eventual -Count spCount

Id                                   DisplayName                                                    AppId                                SignInAudience                     PublisherName
--                                   -----------                                                    -----                                --------------                     -------------
000e4269-1923-4c8c-9c27-1206e114d421 Microsoft Parature Dynamics CRM                                8909aac3-be91-470c-8a0b-ff09d669af91 AzureADMultipleOrgs                Microsoft Services
0012ff3e-9c42-47f9-86a9-3a42aadf3d1d OneProfile Service                                             b2cc270f-563e-4d8a-af47-f00963a71dcd AzureADMultipleOrgs                Microsoft Services
0045f2ae-41d9-4373-98ac-3306fe51c9cf Dynamics Data Integration                                      2e49aa60-1bd3-43b6-8ab6-03ada3d9f08b AzureADMultipleOrgs                Microsoft Services
020ada9b-60b7-436f-8f00-22b198c2996a O365SBRM Service                                               9d06afd9-66c9-49a6-b385-ea7509332b0b AzureADMultipleOrgs                Microsoft Service
```

This example returns a list of all the service principals. $spCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgBetaGraph -Scopes Permission`. For example, `Connect-MgBetaGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 4: Use -Filter and -Top to get five service principals with a display name that starts with 'a' including a count of returned objects

```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaServicePrincipal -ConsistencyLevel eventual -Count spCount -Filter "startsWith(DisplayName, 'a')" -Top 5

Id                                   DisplayName                       AppId                                SignInAudience      PublisherName
--                                   -----------                       -----                                --------------      -------------
0637e98d-34a5-4eac-a0b3-0eb135c2905d Azure Multi-Factor Auth Client    981f26a1-7f43-403b-a875-f8b09b8cd720 AzureADMultipleOrgs Microsoft Services
0c2fce9a-93e1-459d-8e58-32cdb80f0468 AAD Terms Of Use                  d52792f4-ba38-424d-8140-ada5b883f293 AzureADMultipleOrgs Microsoft Services
0e9adb48-e0aa-4aa5-a787-a79acc91f2ad Azure Multi-Factor Auth Connector 1f5530b3-261a-47a9-b357-ded261e17918 AzureADMultipleOrgs Microsoft Services
1b339d7a-b9ba-4328-ae3c-6f21276628c7 Azure Analysis Services           4ac7d521-0382-477b-b0f8-7e1d95f85ca2 AzureADMultipleOrgs Microsoft Services
1d322ee1-7cf7-442a-b480-d6d4bbe6ec54 App Protection                    c6e44401-4d0a-4542-ab22-ecd4c90d28d7 AzureADMultipleOrgs Microsoft Services
```

This example filters service principals whose display name starts with 'a' and continues to return  the top 5. $spCount variable contains the count of the objects in the result before the *Top* filter. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgBetaGraph -Scopes Permission`. For example, `Connect-MgBetaGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 5: Use -Search to get service principals with display names that contain the letters 'Team' including a count of returned objects

```powershell
Connect-MgBetaGraph -Scopes 'Application.Read.All'
Get-MgBetaServicePrincipal -ConsistencyLevel eventual -Count spCount -Search '"DisplayName:Team"'

Id                                   DisplayName                                                 AppId                                SignInAudience                     PublisherName
--                                   -----------                                                 -----                                --------------                     -------------
11068671-11e6-4f5e-9406-a314afe67546 Skype Teams Firehose                                        cdccd920-384b-4a25-897d-75161a4b74c1 AzureADMultipleOrgs                Microsoft Services
270bc0fc-4966-458a-a0e6-ad1d7063c5d9 Teams User Engagement Profile Service                       0f54b75d-4d29-4a92-80ae-106a60cd8f5d AzureADMultipleOrgs                Microsoft Services
2854d6cf-05c7-45b3-8b4b-cda63c2a5158 Skype Teams Calling API Service                             26a18ebc-cdf7-4a6a-91cb-beb352805e81 AzureADMultipleOrgs                Microsoft Services
28a84bbe-88ba-4edc-b3f0-c34b03c1c8a0 Microsoft Teams User Profile Search Service                 a47591ab-e23e-4ffa-9e1b-809b9067e726 AzureADMultipleOrgs                Microsoft Services
29b512aa-7269-4eea-8a61-5125684183cf Teams Calling Meeting Devices Services                      00edd498-7c0c-4e68-859c-5a55d518c9c0 AzureADMultipleOrgs                Microsoft Services
32cba72f-3403-4944-ada7-9173c8678247 App Studio for Microsoft Teams                              e1979c22-8b73-4aed-a4da-572cc4d0b832 AzureADMultipleOrgs                Microsoft Services
349be45f-663d-428e-bdab-b4ac26393614 Microsoft Teams AuthSvc                                     a164aee5-7d0a-46bb-9404-37421d58bdf7 AzureADMultipleOrgs                Microsoft Services
```

This example returns all service principals whose display name contains the word 'team'. $spCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

To learn about other permissions for this resource, see the [permissions reference](/graph/permissions-reference).

To consent to any of these permissions run `Connect-MgBetaGraph -Scopes Permission`. For example, `Connect-MgBetaGraph -Scopes Application.Read.All, Application.ReadWrite.All`.
