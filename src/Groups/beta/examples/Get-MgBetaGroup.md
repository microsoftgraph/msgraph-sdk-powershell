### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup

```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -CountVariable CountVar -Filter "hasMembersWithLicenseErrors eq true" -Property "id,displayName"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -Filter "startswith(displayName, 'a')" -CountVariable CountVar -Top 1 -Sort "displayName"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -Search '"displayName:Video" OR "description:prod"' -Sort "displayName" -CountVariable CountVar  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 5: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -Filter "mailEnabled eq false and securityEnabled eq true and NOT(groupTypes/any(s:s eq 'Unified')) and membershipRuleProcessingState eq 'On'" -CountVariable CountVar -Property "id,membershipRule,membershipRuleProcessingState" 

```
This example shows how to use the Get-MgBetaGroup Cmdlet.

### Example 6: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroup -Property "id,assignedLicenses" -Filter "assignedLicenses/any()" -ExpandProperty "members(`$select=id,displayName)" 

```
This example shows how to use the Get-MgBetaGroup Cmdlet.

