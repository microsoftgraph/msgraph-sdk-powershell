### Example 1: Use a URI to get all related cmdlets
```powershell
PS C:\> Find-MgGraphCommand -Uri "/users/{id}"

 APIVersion: v1.0

Command       Module Method URI              OutputType           Permissions                                                                                                                                                    Variants
-------       ------ ------ ---              ----------           -----------                                                                                                                                                    --------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser1 {DeviceManagementApps.Read.All, DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.Read.All, DeviceManagementManagedDevices.ReadWrite.All...}  {Get1, GetViaIdentity1}
Remove-MgUser Users  DELETE /users/{user-id}                      {DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.ReadWrite.All, DeviceManagementServiceConfig.ReadWrite.All, Directory.AccessAsUser.All}    {Delete, DeleteViaIdentity}
Update-MgUser Users  PATCH  /users/{user-id}                      {DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.ReadWrite.All, DeviceManagementServiceConfig.ReadWrite.All, Directory.AccessAsUser.All...} {Update, UpdateExpanded, UpdateViaIdentity, UpdateViaIdentityExpanded}


   APIVersion: beta

Command       Module Method URI              OutputType          Permissions                                                                                                                                                    Variants
-------       ------ ------ ---              ----------          -----------                                                                                                                                                    --------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser {DeviceManagementApps.Read.All, DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.Read.All, DeviceManagementManagedDevices.ReadWrite.All...}  {Get, GetViaIdentity}
Remove-MgUser Users  DELETE /users/{user-id}                     {DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.ReadWrite.All, DeviceManagementServiceConfig.ReadWrite.All, Directory.AccessAsUser.All}    {Delete1, DeleteViaIdentity1}
Update-MgUser Users  PATCH  /users/{user-id}                     {DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.ReadWrite.All, DeviceManagementServiceConfig.ReadWrite.All, Directory.AccessAsUser.All...} {Update1, UpdateExpanded1, UpdateViaIdentity1, UpdateViaIdentityExpanded1}

```
This example finds all commands that call the provided Microsoft Graph URI.

### Example 2: Pass a command and get the URI it calls
```powershell
PS C:\> Find-MgGraphCommand -Command 'Get-MgUser'

APIVersion: v1.0

Command    Module Method URI              OutputType           Permissions                                                                                                                                                   Variants
-------    ------ ------ ---              ----------           -----------                                                                                                                                                   --------
Get-MgUser Users  GET    /users           IMicrosoftGraphUser1 {DeviceManagementApps.Read.All, DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.Read.All, DeviceManagementManagedDevices.ReadWrite.All...} {List1}
Get-MgUser Users  GET    /users/{user-id} IMicrosoftGraphUser1 {DeviceManagementApps.Read.All, DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.Read.All, DeviceManagementManagedDevices.ReadWrite.All...} {Get1, GetViaIdentity1}


   APIVersion: beta

Command    Module Method URI              OutputType          Permissions                                                                                                                                                   Variants
-------    ------ ------ ---              ----------          -----------                                                                                                                                                   --------
Get-MgUser Users  GET    /users/{user-id} IMicrosoftGraphUser {DeviceManagementApps.Read.All, DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.Read.All, DeviceManagementManagedDevices.ReadWrite.All...} {Get, GetViaIdentity}
Get-MgUser Users  GET    /users           IMicrosoftGraphUser {DeviceManagementApps.Read.All, DeviceManagementApps.ReadWrite.All, DeviceManagementManagedDevices.Read.All, DeviceManagementManagedDevices.ReadWrite.All...} {List}
```
This example looks up a command with the provided command name that calls both beta and v1.0 version of the API.

### Example 3: Pass a command and get the permissions required
```powershell
PS C:\> Find-MgGraphCommand -command Get-MgUser | Select -First 1 -ExpandProperty Permissions

Name                                         IsAdmin Description                                   FullDescription
----                                         ------- -----------                                   ---------------
Directory.AccessAsUser.All                   True    Access the directory as you                   Allows the app to have the same access to information in your work or school directory as you do.
Directory.Read.All                           True    Read directory data                           Allows the app to read data in your organization's directory.
Directory.ReadWrite.All                      True    Read and write directory data                 Allows the app to read and write data in your organization's directory, such as other users, groups.  It does not allow the app to delete users or groups, or reset user...
User.Read.All                                True    Read all users' full profiles                 Allows the app to read the full set of profile properties, reports, and managers of other users in your organization, on your behalf.
User.ReadBasic.All                           False   Read all users' basic profiles                Allows the app to read a basic set of profile properties of other users in your organization on your behalf. Includes display name, first and last name, email address a...
User.ReadWrite.All                           True    Read and write all users' full profiles       Allows the app to read and write the full set of profile properties, reports, and managers of other users in your organization, on your behalf.
```
This example retrieves the scopes required for a particular command.

### Example 4: Find Microsoft Graph PowerShell commands using a command wildcard
```powershell
PS C:\> Find-MgGraphCommand -Command .*UserToDo.* -APIVersion 'v1.0'
   APIVersion: v1.0

Command                                        Module          Method URI
-------                                        ------          ------ ---
Get-MgUserTodoList                             Users           GET    /users/{user-id}/todo/lists
Get-MgUserTodoList                             Users           GET    /users/{user-id}/todo/lists/{todoTaskList-id}
Get-MgUserTodoListDelta                        Users.Functions GET    /users/{user-id}/todo/lists/delta
Get-MgUserTodoListExtension                    Users           GET    /users/{user-id}/todo/lists/{todoTaskList-id}/extensions
Get-MgUserTodoListExtension                    Users           GET    /users/{user-id}/todo/lists/{todoTaskList-id}/extensions/{extension-id}
Get-MgUserTodoListTask                         Users           GET    /users/{user-id}/todo/lists/{todoTaskList-id}/tasks
Get-MgUserTodoListTask                         Users           GET    /users/{user-id}/todo/lists/{todoTaskList-id}/tasks/{todoTask-id}
```
Uses a wildcard syntax to search for commands.

### Example 5: Find Microsoft Graph PowerShell commands using a URI wildcard
```powershell
PS C:\> Find-MgGraphCommand -Uri ".*users.*" -Method 'Get' -ApiVersion 'v1.0'
Command                               Module                       Method URI
-------                               ------                       ------ ---
Get-MgUser                            Users                        GET    /users/{user-id}
Get-MgUser                            Users                        GET    /users
Get-MgUserActivity                    CrossDeviceExperiences       GET    /users/{user-id}/activities/{userActivity-id}
Get-MgUserActivity                    CrossDeviceExperiences       GET    /users/{user-id}/activities
Get-MgUserActivityHistoryItem         CrossDeviceExperiences       GET    /users/{user-id}/activities/{userActivity-id}/historyItems/{activityHistoryItem-id}
```
Searches for commands using URI wildcard.