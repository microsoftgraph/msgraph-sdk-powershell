### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	controlId = "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213"
	controlTypeId = "6e4f3d20-c5c3-407f-9695-8460952bcc68"
	programId = "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213"
}

New-MgBetaProgramControl -BodyParameter $params

```
This example shows how to use the New-MgBetaProgramControl Cmdlet.

