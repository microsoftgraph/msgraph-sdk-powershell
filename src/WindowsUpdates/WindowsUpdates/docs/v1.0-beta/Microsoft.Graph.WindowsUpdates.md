---
Module Name: Microsoft.Graph.WindowsUpdates
Module Guid: 1225acf8-391d-4dc5-81c3-44f23763e453
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.WindowsUpdates Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.WindowsUpdates Cmdlets
### [Add-MgWindowsUpdatesDeploymentAudienceExclusionMemberById](Add-MgWindowsUpdatesDeploymentAudienceExclusionMemberById.md)
Add members of the same type to an updatableAssetGroup.
You can also use the method addMembers to add members.

### [Add-MgWindowsUpdatesDeploymentAudienceMember](Add-MgWindowsUpdatesDeploymentAudienceMember.md)
Add members to an updatableAssetGroup.
You can add azureADDevice resources as members, but may not add **updatableAssetGroup** resources as members.
Adding an Azure AD device as a member of an updatable asset group automatically creates an **azureADDevice** object, if it does not already exist.
You can also use the method addMembersById to add members.

### [Add-MgWindowsUpdatesDeploymentAudienceMemberById](Add-MgWindowsUpdatesDeploymentAudienceMemberById.md)
Add members of the same type to an updatableAssetGroup.
You can also use the method addMembers to add members.

### [Add-MgWindowsUpdatesUpdatableAssetMember](Add-MgWindowsUpdatesUpdatableAssetMember.md)
Add members to an updatableAssetGroup.
You can add azureADDevice resources as members, but may not add **updatableAssetGroup** resources as members.
Adding an Azure AD device as a member of an updatable asset group automatically creates an **azureADDevice** object, if it does not already exist.
You can also use the method addMembersById to add members.

### [Add-MgWindowsUpdatesUpdatableAssetMemberById](Add-MgWindowsUpdatesUpdatableAssetMemberById.md)
Add members of the same type to an updatableAssetGroup.
You can also use the method addMembers to add members.

### [Get-MgWindowsUpdatesCatalogEntry](Get-MgWindowsUpdatesCatalogEntry.md)
Lists the content that you can approve for deployment.
Read-only.

### [Get-MgWindowsUpdatesDeployment](Get-MgWindowsUpdatesDeployment.md)
Deployments created using the deployment service.

### [Get-MgWindowsUpdatesDeploymentAudienceExclusion](Get-MgWindowsUpdatesDeploymentAudienceExclusion.md)
Specifies the assets to exclude from the audience.

### [Get-MgWindowsUpdatesDeploymentAudienceMember](Get-MgWindowsUpdatesDeploymentAudienceMember.md)
Specifies the assets to include in the audience.

### [Get-MgWindowsUpdatesPolicy](Get-MgWindowsUpdatesPolicy.md)
A collection of policies for approving the deployment of different content to an audience over time.

### [Get-MgWindowsUpdatesPolicyAudience](Get-MgWindowsUpdatesPolicyAudience.md)
Specifies the audience to target.

### [Get-MgWindowsUpdatesPolicyComplianceChange](Get-MgWindowsUpdatesPolicyComplianceChange.md)
Compliance changes like content approvals which result in the automatic creation of deployments using the audience and deploymentSettings of the policy.

### [Get-MgWindowsUpdatesPolicyComplianceChangeUpdatePolicy](Get-MgWindowsUpdatesPolicyComplianceChangeUpdatePolicy.md)
The policy this compliance change is a member of.

### [Get-MgWindowsUpdatesResourceConnection](Get-MgWindowsUpdatesResourceConnection.md)
Service connections to external resources such as analytics workspaces.

### [Get-MgWindowsUpdatesUpdatableAsset](Get-MgWindowsUpdatesUpdatableAsset.md)
Assets registered with the deployment service that can receive updates.

### [Invoke-MgEnrollWindowsUpdatesDeploymentAudienceExclusionAssetById](Invoke-MgEnrollWindowsUpdatesDeploymentAudienceExclusionAssetById.md)
Invoke action enrollAssetsById

### [Invoke-MgEnrollWindowsUpdatesDeploymentAudienceMemberAssetById](Invoke-MgEnrollWindowsUpdatesDeploymentAudienceMemberAssetById.md)
Invoke action enrollAssetsById

### [Invoke-MgEnrollWindowsUpdatesUpdatableAsset](Invoke-MgEnrollWindowsUpdatesUpdatableAsset.md)
Invoke action enrollAssets

### [Invoke-MgEnrollWindowsUpdatesUpdatableAssetById](Invoke-MgEnrollWindowsUpdatesUpdatableAssetById.md)
Invoke action enrollAssetsById

### [Invoke-MgGraphWindowsUpdatesDeploymentAudienceExclusion](Invoke-MgGraphWindowsUpdatesDeploymentAudienceExclusion.md)
Invoke action unenrollAssetsById

### [Invoke-MgGraphWindowsUpdatesDeploymentAudienceMember](Invoke-MgGraphWindowsUpdatesDeploymentAudienceMember.md)
Invoke action unenrollAssetsById

### [Invoke-MgGraphWindowsUpdatesUpdatableAsset](Invoke-MgGraphWindowsUpdatesUpdatableAsset.md)
Invoke action unenrollAssetsById

### [Invoke-MgUnenrollWindowsUpdatesUpdatableAsset](Invoke-MgUnenrollWindowsUpdatesUpdatableAsset.md)
Invoke action unenrollAssets

### [New-MgWindowsUpdatesDeployment](New-MgWindowsUpdatesDeployment.md)
Create a new deployment object.

### [New-MgWindowsUpdatesPolicy](New-MgWindowsUpdatesPolicy.md)
Create a new updatePolicy object.

### [New-MgWindowsUpdatesPolicyComplianceChange](New-MgWindowsUpdatesPolicyComplianceChange.md)
Create a new contentApproval object.

### [New-MgWindowsUpdatesResourceConnection](New-MgWindowsUpdatesResourceConnection.md)
Create a new operationalInsightsConnection object.

### [New-MgWindowsUpdatesUpdatableAsset](New-MgWindowsUpdatesUpdatableAsset.md)
Create a new updatableAssetGroup object.
The **updatableAssetGroup** resource inherits from updatableAsset.

### [Remove-MgWindowsUpdatesDeployment](Remove-MgWindowsUpdatesDeployment.md)
Delete navigation property deployments for admin

### [Remove-MgWindowsUpdatesDeploymentAudienceExclusionMemberById](Remove-MgWindowsUpdatesDeploymentAudienceExclusionMemberById.md)
Remove members of the same type from an updatableAssetGroup.
You can also use the method removeMembers to remove members.

### [Remove-MgWindowsUpdatesDeploymentAudienceMemberById](Remove-MgWindowsUpdatesDeploymentAudienceMemberById.md)
Remove members of the same type from an updatableAssetGroup.
You can also use the method removeMembers to remove members.

### [Remove-MgWindowsUpdatesPolicy](Remove-MgWindowsUpdatesPolicy.md)
Delete navigation property updatePolicies for admin

### [Remove-MgWindowsUpdatesPolicyComplianceChange](Remove-MgWindowsUpdatesPolicyComplianceChange.md)
Delete navigation property complianceChanges for admin

### [Remove-MgWindowsUpdatesResourceConnection](Remove-MgWindowsUpdatesResourceConnection.md)
Delete navigation property resourceConnections for admin

### [Remove-MgWindowsUpdatesUpdatableAsset](Remove-MgWindowsUpdatesUpdatableAsset.md)
Delete navigation property updatableAssets for admin

### [Remove-MgWindowsUpdatesUpdatableAssetMember](Remove-MgWindowsUpdatesUpdatableAssetMember.md)
Remove members from an updatableAssetGroup.
You can also use the method removeMembersById to remove members.

### [Remove-MgWindowsUpdatesUpdatableAssetMemberById](Remove-MgWindowsUpdatesUpdatableAssetMemberById.md)
Remove members of the same type from an updatableAssetGroup.
You can also use the method removeMembers to remove members.

### [Update-MgWindowsUpdatesDeployment](Update-MgWindowsUpdatesDeployment.md)
Update the navigation property deployments in admin

### [Update-MgWindowsUpdatesDeploymentAudience](Update-MgWindowsUpdatesDeploymentAudience.md)
Update the members and exclusions collections of a deploymentAudience.
Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object, if it does not already exist.
If the same updatableAsset gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset.
If all **updatableAsset** objects are the same type, you can also use the method updateAudienceById to update the **deploymentAudience**.

### [Update-MgWindowsUpdatesDeploymentAudienceById](Update-MgWindowsUpdatesDeploymentAudienceById.md)
Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type.
Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object if it does not already exist.
If the same updatableAsset gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset.
You can also use the method updateAudience to update the **deploymentAudience**.

### [Update-MgWindowsUpdatesPolicy](Update-MgWindowsUpdatesPolicy.md)
Update the navigation property updatePolicies in admin

### [Update-MgWindowsUpdatesPolicyComplianceChange](Update-MgWindowsUpdatesPolicyComplianceChange.md)
Update the navigation property complianceChanges in admin

### [Update-MgWindowsUpdatesResourceConnection](Update-MgWindowsUpdatesResourceConnection.md)
Update the navigation property resourceConnections in admin

### [Update-MgWindowsUpdatesUpdatableAsset](Update-MgWindowsUpdatesUpdatableAsset.md)
Update the navigation property updatableAssets in admin

