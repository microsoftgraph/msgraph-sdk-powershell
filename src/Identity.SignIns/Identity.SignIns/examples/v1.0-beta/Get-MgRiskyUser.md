### Example 1: List all risky users
```powershell
Connect-MgGraph -Scopes "IdentityRiskyUser.Read.All"
Select-MgProfile beta
Get-MgRiskyUser | Format-Table UserDisplayName, RiskDetail, RiskLevel, RiskLastUpdatedDateTime

UserDisplayName RiskDetail                        RiskLevel RiskLastUpdatedDateTime
--------------- ----------                        --------- -----------------------
Alex Su         adminConfirmedUserCompromised     high      5/30/2022 12:54:16 AM
tracys          adminConfirmedUserCompromised     high      5/30/2022 12:44:25 AM
Jason Mayer     userPerformedSecuredPasswordReset none      7/4/2022 4:36:44 AM
```

This command returns all risky users

### Example 2: List all risky users by RiskLevel
```powershell
Connect-MgGraph -Scopes "IdentityRiskyUser.Read.All"
Select-MgProfile beta
Get-MgRiskyUser -Filter "RiskLevel ne 'none'" | Format-Table UserDisplayName, RiskDetail, RiskLevel, RiskLastUpdatedDateTime

UserDisplayName RiskDetail                    RiskLevel RiskLastUpdatedDateTime
--------------- ----------                    --------- -----------------------
Alex Su         adminConfirmedUserCompromised high      5/30/2022 12:54:16 AM
tracys          adminConfirmedUserCompromised high      5/30/2022 12:44:25 AM
```

This command retruns all risky users whose risk level is not none

