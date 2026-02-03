### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	resource = @{
		displayName = "new pdf file patched.pdf"
	}
}

Update-MgBetaEducationClassModuleResource -EducationClassId $educationClassId -EducationModuleId $educationModuleId -EducationModuleResourceId $educationModuleResourceId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassModuleResource Cmdlet.

