### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId

```
This example shows how to use the Get-MgBetaEducationClassAssignmentSetting Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -ExpandProperty "defaultGradingScheme" 

```
This example shows how to use the Get-MgBetaEducationClassAssignmentSetting Cmdlet.

