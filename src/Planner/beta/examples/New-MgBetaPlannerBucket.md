### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	name = "Advertising"
	planId = "xqQg5FS2LkCp935s-FIFm2QAFkHM"
	orderHint = " !"
}

New-MgBetaPlannerBucket -BodyParameter $params

```
This example shows how to use the New-MgBetaPlannerBucket Cmdlet.

