###Example 1
```
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Fabrikam Arts High School"
	Description = "Magnate school for the arts. Los Angeles School District"
}
Update-MgEducationSchool -EducationSchoolId $educationSchoolId -BodyParameter $params
```
