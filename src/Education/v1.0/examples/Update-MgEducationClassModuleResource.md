### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	resource = @{
		displayName = "New pptx file patched.pptx"
	}
}

Update-MgEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -EducationModuleResourceId $educationModuleResourceId -BodyParameter $params

```
This example shows how to use the Update-MgEducationClassModuleResource Cmdlet.

