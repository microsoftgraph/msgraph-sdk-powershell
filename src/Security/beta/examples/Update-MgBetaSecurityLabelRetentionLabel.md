### Example 1: Using the Update-MgBetaSecurityLabelRetentionLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
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
Update-MgBetaSecurityLabelRetentionLabel -RetentionLabelId $retentionLabelId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityLabelRetentionLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
