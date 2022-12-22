### Example 1: Update a user's manager

```powershell
$NewManager = @{
  "@odata.id"="https://graph.microsoft.com/v1.0/users/075b32dd-edb7-47cf-89ef-f3f733683a3f"
  }

Set-MgUserManagerByRef -UserId '8a7c50d3-fcbd-4727-a889-8ab232dfea01' -BodyParameter $NewManager
```

In this example, the first command defines the new manager using the $NewManager variable with id `075b32dd-edb7-47cf-89ef-f3f733683a3f`.
The second command sets the manager for user defined by the UserId as the value provided on the $NewManager variable.

