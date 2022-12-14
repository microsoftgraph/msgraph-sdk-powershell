### Example 1: Add an owner for a service principal

```powershell
$newOwner = @{
  "@odata.id"= "https://graph.microsoft.com/v1.0/directoryObjects/8a7c50d3-fcbd-4727-a889-8ab232dfea01"
  }

New-MgBetaServicePrincipalOwnerByRef -ServicePrincipalId '1c48f923-4fbb-4d37-b772-4d577eefec9e' -BodyParameter $newOwner
```

In this example, the first command defines the value for the `$newOwner` variable in a hashtable. The second command adds the new owner to the specified service principal.
