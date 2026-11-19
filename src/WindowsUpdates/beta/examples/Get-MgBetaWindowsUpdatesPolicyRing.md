### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

Get-MgBetaWindowsUpdatesPolicyRing -PolicyId $policyId -Filter "isof('microsoft.graph.windowsUpdates.qualityUpdateRing')" 

```
This example shows how to use the Get-MgBetaWindowsUpdatesPolicyRing Cmdlet.

