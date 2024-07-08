### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Functions

# A UPN can also be used as -UserId.
Get-MgUserTodoTaskDelta -UserId $userId -TodoTaskListId $todoTaskListId -Deltatoken "w0vf2jHg2mBXU-I2AK0FSWl0dopNtG8u5YoM" 

```
This example shows how to use the Get-MgUserTodoTaskDelta Cmdlet.

