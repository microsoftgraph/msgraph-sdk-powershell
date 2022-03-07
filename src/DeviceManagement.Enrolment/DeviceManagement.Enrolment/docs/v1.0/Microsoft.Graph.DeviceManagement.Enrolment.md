---
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
Module Guid: 5b57c062-1adf-4684-b8bb-10b1bf9f82d1
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
Read-only.
Nullable.

### [Get-MgRoleManagementDirectoryRoleAssignment](Get-MgRoleManagementDirectoryRoleAssignment.md)
Resource to grant access to users or groups.

### [Get-MgRoleManagementDirectoryRoleAssignmentAppScope](Get-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScopeByRef](Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScopeByRef.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentPrincipal](Get-MgRoleManagementDirectoryRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentPrincipalByRef](Get-MgRoleManagementDirectoryRoleAssignmentPrincipalByRef.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinitionByRef](Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinitionByRef.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleDefinition](Get-MgRoleManagementDirectoryRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Get-MgRoleManagementEntitlementManagement](Get-MgRoleManagementEntitlementManagement.md)
Container for all entitlement management resources in Azure AD identity governance.

### [Get-MgRoleManagementEntitlementManagementRoleAssignment](Get-MgRoleManagementEntitlementManagementRoleAssignment.md)
Resource to grant access to users or groups.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScopeByRef](Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScopeByRef.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipalByRef](Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipalByRef.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinitionByRef](Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinitionByRef.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [New-MgDeviceManagementDeviceEnrollmentConfiguration](New-MgDeviceManagementDeviceEnrollmentConfiguration.md)
The list of device enrollment configurations

### [New-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](New-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
The list of group assignments for the device configuration profile

### [New-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](New-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Collection of imported Windows autopilot devices.

### [New-MgDeviceManagementWindowAutopilotDeviceIdentity](New-MgDeviceManagementWindowAutopilotDeviceIdentity.md)
The Windows autopilot device identities contained collection.

### [New-MgRoleManagementDirectoryRoleAssignment](New-MgRoleManagementDirectoryRoleAssignment.md)
Resource to grant access to users or groups.

### [New-MgRoleManagementDirectoryRoleDefinition](New-MgRoleManagementDirectoryRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [New-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](New-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [New-MgRoleManagementEntitlementManagementRoleAssignment](New-MgRoleManagementEntitlementManagementRoleAssignment.md)
Resource to grant access to users or groups.

### [New-MgRoleManagementEntitlementManagementRoleDefinition](New-MgRoleManagementEntitlementManagementRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [New-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](New-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Remove-MgDeviceManagementConditionalAccessSetting](Remove-MgDeviceManagementConditionalAccessSetting.md)
The Exchange on premises conditional access settings.
On premises conditional access will require devices to be both enrolled and compliant for mail access

### [Remove-MgDeviceManagementDeviceEnrollmentConfiguration](Remove-MgDeviceManagementDeviceEnrollmentConfiguration.md)
The list of device enrollment configurations

### [Remove-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](Remove-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
The list of group assignments for the device configuration profile

### [Remove-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](Remove-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Collection of imported Windows autopilot devices.

### [Remove-MgDeviceManagementWindowAutopilotDeviceIdentity](Remove-MgDeviceManagementWindowAutopilotDeviceIdentity.md)
The Windows autopilot device identities contained collection.

### [Remove-MgRoleManagementDirectory](Remove-MgRoleManagementDirectory.md)
Read-only.
Nullable.

### [Remove-MgRoleManagementDirectoryRoleAssignment](Remove-MgRoleManagementDirectoryRoleAssignment.md)
Resource to grant access to users or groups.

### [Remove-MgRoleManagementDirectoryRoleAssignmentAppScope](Remove-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Remove-MgRoleManagementDirectoryRoleAssignmentDirectoryScopeByRef](Remove-MgRoleManagementDirectoryRoleAssignmentDirectoryScopeByRef.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Remove-MgRoleManagementDirectoryRoleAssignmentPrincipalByRef](Remove-MgRoleManagementDirectoryRoleAssignmentPrincipalByRef.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Remove-MgRoleManagementDirectoryRoleAssignmentRoleDefinitionByRef](Remove-MgRoleManagementDirectoryRoleAssignmentRoleDefinitionByRef.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Remove-MgRoleManagementDirectoryRoleDefinition](Remove-MgRoleManagementDirectoryRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Remove-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Remove-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Remove-MgRoleManagementEntitlementManagement](Remove-MgRoleManagementEntitlementManagement.md)
Container for all entitlement management resources in Azure AD identity governance.

### [Remove-MgRoleManagementEntitlementManagementRoleAssignment](Remove-MgRoleManagementEntitlementManagementRoleAssignment.md)
Resource to grant access to users or groups.

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Remove-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScopeByRef](Remove-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScopeByRef.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentPrincipalByRef](Remove-MgRoleManagementEntitlementManagementRoleAssignmentPrincipalByRef.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinitionByRef](Remove-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinitionByRef.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Remove-MgRoleManagementEntitlementManagementRoleDefinition](Remove-MgRoleManagementEntitlementManagementRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Remove-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Remove-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Set-MgRoleManagementDirectoryRoleAssignmentDirectoryScopeByRef](Set-MgRoleManagementDirectoryRoleAssignmentDirectoryScopeByRef.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Set-MgRoleManagementDirectoryRoleAssignmentPrincipalByRef](Set-MgRoleManagementDirectoryRoleAssignmentPrincipalByRef.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Set-MgRoleManagementDirectoryRoleAssignmentRoleDefinitionByRef](Set-MgRoleManagementDirectoryRoleAssignmentRoleDefinitionByRef.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Set-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScopeByRef](Set-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScopeByRef.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Set-MgRoleManagementEntitlementManagementRoleAssignmentPrincipalByRef](Set-MgRoleManagementEntitlementManagementRoleAssignmentPrincipalByRef.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Set-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinitionByRef](Set-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinitionByRef.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Update-MgDeviceManagementConditionalAccessSetting](Update-MgDeviceManagementConditionalAccessSetting.md)
The Exchange on premises conditional access settings.
On premises conditional access will require devices to be both enrolled and compliant for mail access

### [Update-MgDeviceManagementDeviceEnrollmentConfiguration](Update-MgDeviceManagementDeviceEnrollmentConfiguration.md)
The list of device enrollment configurations

### [Update-MgDeviceManagementDeviceEnrollmentConfigurationAssignment](Update-MgDeviceManagementDeviceEnrollmentConfigurationAssignment.md)
The list of group assignments for the device configuration profile

### [Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity](Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity.md)
Collection of imported Windows autopilot devices.

### [Update-MgRoleManagement](Update-MgRoleManagement.md)
Update roleManagement

### [Update-MgRoleManagementDirectory](Update-MgRoleManagementDirectory.md)
Read-only.
Nullable.

### [Update-MgRoleManagementDirectoryRoleAssignment](Update-MgRoleManagementDirectoryRoleAssignment.md)
Resource to grant access to users or groups.

### [Update-MgRoleManagementDirectoryRoleAssignmentAppScope](Update-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Update-MgRoleManagementDirectoryRoleDefinition](Update-MgRoleManagementDirectoryRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Update-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Update-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Update-MgRoleManagementEntitlementManagement](Update-MgRoleManagementEntitlementManagement.md)
Container for all entitlement management resources in Azure AD identity governance.

### [Update-MgRoleManagementEntitlementManagementRoleAssignment](Update-MgRoleManagementEntitlementManagementRoleAssignment.md)
Resource to grant access to users or groups.

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Update-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Update-MgRoleManagementEntitlementManagementRoleDefinition](Update-MgRoleManagementEntitlementManagementRoleDefinition.md)
Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.

### [Update-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Update-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

