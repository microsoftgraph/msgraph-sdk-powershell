### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	id = "314ac440-129f-4cb3-ad61-24ef4a7de1d9"
}

Remove-MgBetaGroupPasswordSingleSignOnCredential -GroupId $groupId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaGroupPasswordSingleSignOnCredential Cmdlet.

