### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	displayName = "New_Module5 updated"
	description = "updated for description"
}

Update-MgEducationClassModule -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example shows how to use the Update-MgEducationClassModule Cmdlet.

