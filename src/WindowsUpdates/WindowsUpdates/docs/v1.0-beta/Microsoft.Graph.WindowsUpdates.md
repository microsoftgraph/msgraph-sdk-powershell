---
Module Name: Microsoft.Graph.Beta.WindowsUpdates
Module Guid: a2be5123-b9fe-40b8-9185-cc6671ab95cd
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.windowsupdates
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.WindowsUpdates Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.WindowsUpdates Cmdlets
### [Add-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById](Add-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById.md)
Add members of the same type to an updatableAssetGroup.
You can also use the method addMembers to add members.

### [Add-MgBetaWindowsUpdatesDeploymentAudienceMember](Add-MgBetaWindowsUpdatesDeploymentAudienceMember.md)
Add members to an updatableAssetGroup.
You can add azureADDevice resources as members, but may not add **updatableAssetGroup** resources as members.
Adding an Azure AD device as a member of an updatable asset group automatically creates an **azureADDevice** object, if it does not already exist.
You can also use the method addMembersById to add members.

### [Add-MgBetaWindowsUpdatesDeploymentAudienceMemberById](Add-MgBetaWindowsUpdatesDeploymentAudienceMemberById.md)
Add members of the same type to an updatableAssetGroup.
You can also use the method addMembers to add members.

### [Add-MgBetaWindowsUpdatesUpdatableAssetMember](Add-MgBetaWindowsUpdatesUpdatableAssetMember.md)
Add members to an updatableAssetGroup.
You can add azureADDevice resources as members, but may not add **updatableAssetGroup** resources as members.
Adding an Azure AD device as a member of an updatable asset group automatically creates an **azureADDevice** object, if it does not already exist.
You can also use the method addMembersById to add members.

### [Add-MgBetaWindowsUpdatesUpdatableAssetMemberById](Add-MgBetaWindowsUpdatesUpdatableAssetMemberById.md)
Add members of the same type to an updatableAssetGroup.
You can also use the method addMembers to add members.

### [Get-MgBetaWindowsUpdatesCatalogEntry](Get-MgBetaWindowsUpdatesCatalogEntry.md)
Lists the content that you can approve for deployment.
Read-only.

### [Get-MgBetaWindowsUpdatesDeployment](Get-MgBetaWindowsUpdatesDeployment.md)
Deployments created using the deployment service.
Read-only.

### [Get-MgBetaWindowsUpdatesDeploymentAudienceExclusion](Get-MgBetaWindowsUpdatesDeploymentAudienceExclusion.md)
Specifies the assets to exclude from the audience.

### [Get-MgBetaWindowsUpdatesDeploymentAudienceMember](Get-MgBetaWindowsUpdatesDeploymentAudienceMember.md)
Specifies the assets to include in the audience.

### [Get-MgBetaWindowsUpdatesResourceConnection](Get-MgBetaWindowsUpdatesResourceConnection.md)
Service connections to external resources such as analytics workspaces.

### [Get-MgBetaWindowsUpdatesUpdatableAsset](Get-MgBetaWindowsUpdatesUpdatableAsset.md)
Assets registered with the deployment service that can receive updates.
Read-only.

### [Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceExclusionAssetById](Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceExclusionAssetById.md)
Invoke action enrollAssetsById

### [Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById](Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById.md)
Invoke action enrollAssetsById

### [Invoke-MgBetaEnrollWindowsUpdatesUpdatableAsset](Invoke-MgBetaEnrollWindowsUpdatesUpdatableAsset.md)
Invoke action enrollAssets

### [Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById](Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById.md)
Invoke action enrollAssetsById

### [Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceExclusion](Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceExclusion.md)
Invoke action unenrollAssetsById

### [Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember](Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember.md)
Invoke action unenrollAssetsById

### [Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset](Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset.md)
Invoke action unenrollAssetsById

### [Invoke-MgBetaUnenrollWindowsUpdatesUpdatableAsset](Invoke-MgBetaUnenrollWindowsUpdatesUpdatableAsset.md)
Invoke action unenrollAssets

### [New-MgBetaWindowsUpdatesDeployment](New-MgBetaWindowsUpdatesDeployment.md)
Create a new deployment object.

### [New-MgBetaWindowsUpdatesResourceConnection](New-MgBetaWindowsUpdatesResourceConnection.md)
Create a new operationalInsightsConnection object.

### [New-MgBetaWindowsUpdatesUpdatableAsset](New-MgBetaWindowsUpdatesUpdatableAsset.md)
Create a new updatableAssetGroup object.
The **updatableAssetGroup** resource inherits from updatableAsset.

### [Remove-MgBetaWindowsUpdatesDeployment](Remove-MgBetaWindowsUpdatesDeployment.md)
Delete navigation property deployments for admin

### [Remove-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById](Remove-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById.md)
Remove members of the same type from an updatableAssetGroup.
You can also use the method removeMembers to remove members.

### [Remove-MgBetaWindowsUpdatesDeploymentAudienceMemberById](Remove-MgBetaWindowsUpdatesDeploymentAudienceMemberById.md)
Remove members of the same type from an updatableAssetGroup.
You can also use the method removeMembers to remove members.

### [Remove-MgBetaWindowsUpdatesResourceConnection](Remove-MgBetaWindowsUpdatesResourceConnection.md)
Delete navigation property resourceConnections for admin

### [Remove-MgBetaWindowsUpdatesUpdatableAsset](Remove-MgBetaWindowsUpdatesUpdatableAsset.md)
Delete navigation property updatableAssets for admin

### [Remove-MgBetaWindowsUpdatesUpdatableAssetMember](Remove-MgBetaWindowsUpdatesUpdatableAssetMember.md)
Remove members from an updatableAssetGroup.
You can also use the method removeMembersById to remove members.

### [Remove-MgBetaWindowsUpdatesUpdatableAssetMemberById](Remove-MgBetaWindowsUpdatesUpdatableAssetMemberById.md)
Remove members of the same type from an updatableAssetGroup.
You can also use the method removeMembers to remove members.

### [Update-MgBetaWindowsUpdatesDeployment](Update-MgBetaWindowsUpdatesDeployment.md)
Update the navigation property deployments in admin

### [Update-MgBetaWindowsUpdatesDeploymentAudience](Update-MgBetaWindowsUpdatesDeploymentAudience.md)
Update the members and exclusions collections of a deploymentAudience.
Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object, if it does not already exist.
If the same updatableAsset gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset.
If all **updatableAsset** objects are the same type, you can also use the method updateAudienceById to update the **deploymentAudience**.

### [Update-MgBetaWindowsUpdatesDeploymentAudienceById](Update-MgBetaWindowsUpdatesDeploymentAudienceById.md)
Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type.
Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object if it does not already exist.
If the same updatableAsset gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset.
You can also use the method updateAudience to update the **deploymentAudience**.

### [Update-MgBetaWindowsUpdatesResourceConnection](Update-MgBetaWindowsUpdatesResourceConnection.md)
Update the navigation property resourceConnections in admin

### [Update-MgBetaWindowsUpdatesUpdatableAsset](Update-MgBetaWindowsUpdatesUpdatableAsset.md)
Update the navigation property updatableAssets in admin

