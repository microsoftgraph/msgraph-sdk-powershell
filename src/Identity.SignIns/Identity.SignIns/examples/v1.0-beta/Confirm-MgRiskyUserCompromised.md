### Example 1: Confirm User sign in compormised 
```powershell
Connect-MgGraph -Scopes "IdentityRiskyUser.ReadWrite.All"
Select-MgProfile beta
Confirm-MgRiskyUserCompromised -UserIds  "254562e7-a745-496d-b98a-f6770b23152a","8f2ef8bf-53be-45f3-822d-366f51067458"

```
The command confirms the two users as compormised users.


