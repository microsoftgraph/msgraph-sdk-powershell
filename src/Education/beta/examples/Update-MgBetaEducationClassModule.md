### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "New_Module5 updated"
	languageTag = "en-GB"
	description = "updated for description"
}

Update-MgBetaEducationClassModule -EducationClassId $educationClassId -EducationModuleId $educationModuleId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassModule Cmdlet.

