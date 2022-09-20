### Example 1: Using the Update-MgSecurityLabelRetentionLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionLabel"
	DisplayName = "String"
	BehaviorDuringRetentionPeriod = "String"
	ActionAfterRetentionPeriod = "String"
	RetentionTrigger = "String"
	RetentionDuration = @{
		"@odata.type" = "microsoft.graph.security.retentionDuration"
	}
	IsInUse = "Boolean"
	DescriptionForAdmins = "String"
	DescriptionForUsers = "String"
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	LabelToBeApplied = "String"
	DefaultRecordBehavior = "String"
}
Update-MgSecurityLabelRetentionLabel -RetentionLabelId $retentionLabelId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityLabelRetentionLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
