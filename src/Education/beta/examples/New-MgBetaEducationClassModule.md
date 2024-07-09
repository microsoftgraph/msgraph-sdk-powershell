### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Module 2"
	description = "Description for Module 2"
}

New-MgBetaEducationClassModule -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationClassModule Cmdlet.

