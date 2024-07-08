### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -GroupId $groupId

```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -GroupId $groupId -Property "allowExternalSenders,autoSubscribeNewMembers,isSubscribedByMail,unseenCount" 

```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -GroupId $groupId -Property "isManagementRestricted" 

```
This example shows how to use the Get-MgBetaGroup Cmdlet.

