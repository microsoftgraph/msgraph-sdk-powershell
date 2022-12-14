---
Module Name: Microsoft.Graph.DirectoryObjects
Module Guid: df9d5e6f-3d64-4db1-8da4-9cf0ee966bdd
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.directoryobjects
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.DirectoryObjects Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.DirectoryObjects Cmdlets
### [Confirm-MgDirectoryObjectMemberGroup](Confirm-MgDirectoryObjectMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgDirectoryObjectMemberObject](Confirm-MgDirectoryObjectMemberObject.md)
Invoke action checkMemberObjects

### [Get-MgDirectoryObject](Get-MgDirectoryObject.md)
Retrieve the properties and relationships of a directoryObject object.

### [Get-MgDirectoryObjectAvailableExtensionProperty](Get-MgDirectoryObjectAvailableExtensionProperty.md)
Return all directory extension definitions that have been registered in a directory, including through multi-tenant apps.
The following entities support extension properties:\n+ user\n+ group\n+ administrativeUnit\n+ application\n+ device\n+ organization

### [Get-MgDirectoryObjectById](Get-MgDirectoryObjectById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgDirectoryObjectMemberGroup](Get-MgDirectoryObjectMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgDirectoryObjectMemberObject](Get-MgDirectoryObjectMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
**Note:** Only users and role-enabled groups can be members of directory roles.

### [New-MgDirectoryObject](New-MgDirectoryObject.md)
Add new entity to directoryObjects

### [Remove-MgDirectoryObject](Remove-MgDirectoryObject.md)
Delete a directory object, for example, a group, user, application, or service principal.

### [Test-MgDirectoryObjectProperty](Test-MgDirectoryObjectProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
To validate the properties of an existing group, use the group: validateProperties function.
The following policy validations are performed for the display name and mail nickname properties:\n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate that the mail nickname is unique This API only returns the first validation failure that is encountered.
If the properties fail multiple validations, only the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
To learn more about configuring naming policies, see Configure naming policy.

### [Update-MgDirectoryObject](Update-MgDirectoryObject.md)
Update entity in directoryObjects

