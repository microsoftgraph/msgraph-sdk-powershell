### Example 1: List history of a specific user
```powershell
Connect-MgGraph -Scopes "IdentityRiskyUser.Read.All"
Select-MgProfile beta
Get-MgRiskyUserHistory -RiskyUserId 375844b0-2026-4265-b9f1-ee1708491e05 | Format-Table RiskDetail, RiskLastUpdatedDateTime, RiskState, UserDisplayName

RiskDetail                         RiskLastUpdatedDateTime RiskState            UserDisplayName
----------                         ----------------------- ---------            ---------------
userPerformedSecuredPasswordReset  5/4/2022 10:54:35 PM    remediated           Jason Mayer
adminConfirmedUserCompromised      5/27/2022 11:26:40 PM   confirmedCompromised Jason Mayer
adminDismissedAllRiskForUser       5/27/2022 11:28:07 PM   dismissed            Jason Mayer
none                               4/20/2022 3:33:58 PM    atRisk               Jason Mayer
none                               4/21/2022 9:58:21 PM    atRisk               Jason Mayer
```

The command return all the user risk history 
