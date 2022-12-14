---
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
Module Guid: 34812d3a-0cee-441c-9990-9bb48dfc8bbe
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.DeviceManagement.Enrolment Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.DeviceManagement.Enrolment Cmdlets
### [Get-MgDeviceManagementConditionalAccessSetting](Get-MgDeviceManagementConditionalAccessSetting.md)
The Exchange on premises conditional access settings.
On premises conditional access will require devices to be both enrolled and compliant for mail access

### [Get-MgDeviceManagementDeviceEnrollmentConfiguration](Get-MgDeviceManagementDeviceEnrollmentConfiguration.md)
The list of device enrollment configurations

### [Get-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](Get-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
The list of group assignments for the device configuration profile

### [Get-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](Get-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Collection of imported Windows autopilot devices.

### [Get-MgDeviceManagementWindowAutopilotDeviceIdentity](Get-MgDeviceManagementWindowAutopilotDeviceIdentity.md)
The Windows autopilot device identities contained collection.

### [Get-MgRoleManagement](Get-MgRoleManagement.md)
Get roleManagement

### [Get-MgRoleManagementDirectory](Get-MgRoleManagementDirectory.md)
Get directory from roleManagement

### [Get-MgRoleManagementDirectoryRoleAssignment](Get-MgRoleManagementDirectoryRoleAssignment.md)
Resource to grant access to users or groups.

### [Get-MgRoleManagementDirectoryRoleAssignmentAppScope](Get-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Read-only property with details of the app specific scope when the assignment scope is app specific.
Containment entity.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentPrincipal](Get-MgRoleManagementDirectoryRoleAssignmentPrincipal.md)
Referencing the assigned principal.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Supports $expand.
roleDefinition.Id will be auto expanded.

### [Get-MgRoleManagementDirectoryRoleAssignmentSchedule](Get-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Schedules for active role assignment operations.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleActivatedUsing](Get-MgRoleManagementDirectoryRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Instances for active role assignments.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceActivatedUsing](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Requests for active role assignments to principals through PIM.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestActivatedUsing](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestAppScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestPrincipal](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestTargetSchedule](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleDefinition](Get-MgRoleManagementDirectoryRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles (isBuiltIn is true) support this attribute.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilitySchedule](Get-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Schedules for role eligibility operations.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Instances for role eligibility requests.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Requests for role eligibilities for principals through PIM.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestAppScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestDirectoryScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestPrincipal](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestRoleDefinition](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestTargetSchedule](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagement](Get-MgRoleManagementEntitlementManagement.md)
Container for roles and assignments for entitlement management resources.

### [Get-MgRoleManagementEntitlementManagementRoleAssignment](Get-MgRoleManagementEntitlementManagementRoleAssignment.md)
Resource to grant access to users or groups.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Read-only property with details of the app specific scope when the assignment scope is app specific.
Containment entity.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipal.md)
Referencing the assigned principal.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Supports $expand.
roleDefinition.Id will be auto expanded.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](Get-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Schedules for active role assignment operations.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleActivatedUsing](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Instances for active role assignments.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceActivatedUsing](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Requests for active role assignments to principals through PIM.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestActivatedUsing](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestPrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestTargetSchedule](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles (isBuiltIn is true) support this attribute.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](Get-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Schedules for role eligibility operations.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Instances for role eligibility requests.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Requests for role eligibilities for principals through PIM.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestPrincipal](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestTargetSchedule](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [New-MgDeviceManagementDeviceEnrollmentConfiguration](New-MgDeviceManagementDeviceEnrollmentConfiguration.md)
Create new navigation property to deviceEnrollmentConfigurations for deviceManagement

### [New-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](New-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
Create new navigation property to assignments for deviceManagement

### [New-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](New-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Create new navigation property to importedWindowsAutopilotDeviceIdentities for deviceManagement

### [New-MgDeviceManagementWindowAutopilotDeviceIdentity](New-MgDeviceManagementWindowAutopilotDeviceIdentity.md)
Create new navigation property to windowsAutopilotDeviceIdentities for deviceManagement

### [New-MgRoleManagementDirectoryRoleAssignment](New-MgRoleManagementDirectoryRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgRoleManagementDirectoryRoleAssignmentSchedule](New-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](New-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
In PIM, carry out the following operations through the unifiedRoleAssignmentScheduleRequest object:\n+ Request active and persistent role assignments for a principal, with or without expiry dates.\n+ Activate, deactivate, extend, or renew an eligible role assignment for a principal.
To call this API to update, renew, and extend assignments for yourself, you must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgRoleManagementDirectoryRoleDefinition](New-MgRoleManagementDirectoryRoleDefinition.md)
Create a new custom unifiedRoleDefinition object.
This feature requires an Azure AD Premium P1 or P2 license.

### [New-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](New-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgRoleManagementDirectoryRoleEligibilitySchedule](New-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](New-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
In PIM, request for a role eligibility for a principal through the unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [New-MgRoleManagementEntitlementManagementRoleAssignment](New-MgRoleManagementEntitlementManagementRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](New-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
In PIM, carry out the following operations through the unifiedRoleAssignmentScheduleRequest object:\n+ Request active and persistent role assignments for a principal, with or without expiry dates.\n+ Activate, deactivate, extend, or renew an eligible role assignment for a principal.
To call this API to update, renew, and extend assignments for yourself, you must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgRoleManagementEntitlementManagementRoleDefinition](New-MgRoleManagementEntitlementManagementRoleDefinition.md)
Create a new custom unifiedRoleDefinition object.
This feature requires an Azure AD Premium P1 or P2 license.

### [New-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](New-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](New-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
In PIM, request for a role eligibility for a principal through the unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [Remove-MgDeviceManagementConditionalAccessSetting](Remove-MgDeviceManagementConditionalAccessSetting.md)
Delete navigation property conditionalAccessSettings for deviceManagement

### [Remove-MgDeviceManagementDeviceEnrollmentConfiguration](Remove-MgDeviceManagementDeviceEnrollmentConfiguration.md)
Delete navigation property deviceEnrollmentConfigurations for deviceManagement

### [Remove-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](Remove-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
Delete navigation property assignments for deviceManagement

### [Remove-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](Remove-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Delete navigation property importedWindowsAutopilotDeviceIdentities for deviceManagement

### [Remove-MgDeviceManagementWindowAutopilotDeviceIdentity](Remove-MgDeviceManagementWindowAutopilotDeviceIdentity.md)
Delete navigation property windowsAutopilotDeviceIdentities for deviceManagement

### [Remove-MgRoleManagementDirectory](Remove-MgRoleManagementDirectory.md)
Delete navigation property directory for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignment](Remove-MgRoleManagementDirectoryRoleAssignment.md)
Delete navigation property roleAssignments for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentAppScope](Remove-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentSchedule](Remove-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](Remove-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Remove-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgRoleManagementDirectoryRoleDefinition](Remove-MgRoleManagementDirectoryRoleDefinition.md)
Delete navigation property roleDefinitions for roleManagement

### [Remove-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Remove-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgRoleManagementDirectoryRoleEligibilitySchedule](Remove-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](Remove-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Remove-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Remove-MgRoleManagementEntitlementManagement](Remove-MgRoleManagementEntitlementManagement.md)
Delete navigation property entitlementManagement for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignment](Remove-MgRoleManagementEntitlementManagementRoleAssignment.md)
Delete navigation property roleAssignments for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Remove-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](Remove-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleDefinition](Remove-MgRoleManagementEntitlementManagementRoleDefinition.md)
Delete navigation property roleDefinitions for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Remove-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](Remove-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Stop-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Stop-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.

### [Stop-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Stop-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest object whose status is `Granted` and have the system automatically delete the cancelled request after 30 days.
After calling this action, the **status** of the cancelled **unifiedRoleEligibilityScheduleRequest** changes to `Revoked`.

### [Stop-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Stop-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.

### [Stop-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Stop-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest object whose status is `Granted` and have the system automatically delete the cancelled request after 30 days.
After calling this action, the **status** of the cancelled **unifiedRoleEligibilityScheduleRequest** changes to `Revoked`.

### [Update-MgDeviceManagementConditionalAccessSetting](Update-MgDeviceManagementConditionalAccessSetting.md)
Update the navigation property conditionalAccessSettings in deviceManagement

### [Update-MgDeviceManagementDeviceEnrollmentConfiguration](Update-MgDeviceManagementDeviceEnrollmentConfiguration.md)
Update the navigation property deviceEnrollmentConfigurations in deviceManagement

### [Update-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](Update-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
Update the navigation property assignments in deviceManagement

### [Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Update the navigation property importedWindowsAutopilotDeviceIdentities in deviceManagement

### [Update-MgRoleManagement](Update-MgRoleManagement.md)
Update roleManagement

### [Update-MgRoleManagementDirectory](Update-MgRoleManagementDirectory.md)
Update the navigation property directory in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignment](Update-MgRoleManagementDirectoryRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentAppScope](Update-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentSchedule](Update-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](Update-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Update-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgRoleManagementDirectoryRoleDefinition](Update-MgRoleManagementDirectoryRoleDefinition.md)
Update the navigation property roleDefinitions in roleManagement

### [Update-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Update-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgRoleManagementDirectoryRoleEligibilitySchedule](Update-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](Update-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Update-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

### [Update-MgRoleManagementEntitlementManagement](Update-MgRoleManagementEntitlementManagement.md)
Update the navigation property entitlementManagement in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignment](Update-MgRoleManagementEntitlementManagementRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Update-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](Update-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleDefinition](Update-MgRoleManagementEntitlementManagementRoleDefinition.md)
Update the navigation property roleDefinitions in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Update-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](Update-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

