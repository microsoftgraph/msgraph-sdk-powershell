### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	displayName = "Module 1"
	description = "Description for Module 1"
}

New-MgEducationClassModule -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the New-MgEducationClassModule Cmdlet.

