### Example 1: Get a user's direct reports

```powershell
Get-MgBetaUserDirectReport -UserId '075b32dd-edb7-47cf-89ef-f3f733683a3f'

Id                                   DeletedDateTime
--                                   ---------------
185190a7-54f0-4892-add3-211c21327570
f890ceed-822a-4647-8748-73d88013ae9d
58fcff93-a667-4c5f-bd43-372a43f446bc
8a7c50d3-fcbd-4727-a889-8ab232dfea01
68906e46-27f9-4c5e-914b-b931696088fe
```

This example gets the direct reports for the specified user.
